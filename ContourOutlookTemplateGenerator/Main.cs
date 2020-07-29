using System;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ContourOutlookTemplateGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            DateTime current = Date.Value;
            var time = current.ToString("tt", CultureInfo.InvariantCulture);
            if (time.Equals("AM", StringComparison.OrdinalIgnoreCase))
            {
                Date.Value = current.AddDays(-1);
            }

            TimeIn.Format = DateTimePickerFormat.Custom;
            TimeIn.CustomFormat = "hh:mm tt";
            TimeIn.ShowUpDown = true;

            TimeOut.Format = DateTimePickerFormat.Custom;
            TimeOut.CustomFormat = "hh:mm tt";
            TimeOut.ShowUpDown = true;

            RefreshConfigurations(); 
            TimeIn.Value = Date.Value;
            ManualHoursEntry.CheckStateChanged += ManualHoursEntry_CheckStateChanged;
        }

        private void ManualHoursEntry_CheckStateChanged(object sender, EventArgs e)
        {
            if (ManualHoursEntry.Checked)
            {
                Hours.Enabled = true;
            }
            else
            {
                Hours.Enabled = false;
                CalculateHours();
            }
        }

        private void OpenOutlook()
        {
            try {
                
                Outlook.Application application = new Outlook.Application();
                Outlook._MailItem mailItem = (Outlook._MailItem)application.CreateItem(Outlook.OlItemType.olMailItem);
                mailItem.To = ConfigurationManager.AppSettings["To"];
                mailItem.CC = ConfigurationManager.AppSettings["CC"];
                mailItem.Subject = "WFH - " + Date.Value.ToString("dd-MMM-yyyy");

                var body = "Time In: " + TimeIn.Value.ToString("hh:mm tt").ToUpper() + Environment.NewLine;
                body += "Time Out: " + TimeOut.Value.ToString("hh:mm tt").ToUpper() + Environment.NewLine;
                body += "Hours: " + Hours.Value + Environment.NewLine;
                body += "Employee Code: " + EmployeeCode.Text;

                mailItem.Body = body;
                mailItem.Display(true);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Outlook Interop Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void OutlookButton_Click(object sender, EventArgs e)
        {
            Thread worker = new Thread(new ThreadStart(OpenOutlook));
            worker.IsBackground = true;
            worker.Start();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var config = new Configurations();
            config.FormClosed += Config_FormClosed;
            config.ShowDialog();
        }

        private void Config_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshConfigurations();
        }

        private void RefreshConfigurations()
        {
            EmployeeCode.Text = ConfigurationManager.AppSettings["EmployeeCode"];
            To.Text = ConfigurationManager.AppSettings["To"];
            CC.Text = ConfigurationManager.AppSettings["CC"];
        }

        private void TimeIn_ValueChanged(object sender, EventArgs e)
        {
            if (!ManualHoursEntry.Checked)
                CalculateHours();
        }

        private void TimeOut_ValueChanged(object sender, EventArgs e)
        {
            if(!ManualHoursEntry.Checked)
                CalculateHours();
        }

        private void CalculateHours()
        {
            TimeSpan diff = (TimeOut.Value - TimeIn.Value).Duration();
            var duration = diff.Hours + (diff.Minutes / 60.0);
            Hours.Value = Convert.ToDecimal(duration);
        }
    }
}
