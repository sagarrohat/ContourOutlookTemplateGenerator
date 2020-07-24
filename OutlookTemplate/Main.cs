using System;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookTemplate
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
        }

        private void OpenOutlook()
        {
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
    }
}
