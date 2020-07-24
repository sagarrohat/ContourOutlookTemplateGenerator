using System;
using System.Configuration;
using System.Windows.Forms;

namespace OutlookTemplate
{
    public partial class Configurations : Form
    {

        public Configurations()
        {
            InitializeComponent();
            RefreshConfigurations();
        }

        private void RefreshConfigurations()
        {
            EmployeeCode.Text = ConfigurationManager.AppSettings["EmployeeCode"];
            To.Text = ConfigurationManager.AppSettings["To"];
            CC.Text = ConfigurationManager.AppSettings["CC"];
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {            
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection appSettingsSection = configuration.AppSettings;
            appSettingsSection.Settings["To"].Value = To.Text;
            appSettingsSection.Settings["CC"].Value = CC.Text;
            appSettingsSection.Settings["EmployeeCode"].Value = EmployeeCode.Text;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
            RefreshConfigurations();
            this.Close();
        }
    }
}
