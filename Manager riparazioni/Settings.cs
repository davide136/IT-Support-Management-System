using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class Settings : Form
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        String saved_config = ConfigurationManager.AppSettings["db_uri"];


        public Settings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Load_Settings(object sender, EventArgs e)
        {
            ConfigurationManager.RefreshSection("db_uri");
            textBox1.Text = saved_config.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings.Remove("db_uri");
            config.AppSettings.Settings.Add("db_uri", textBox1.Text);
            config.Save();
            ConfigurationManager.RefreshSection("db_uri");

            this.Close();
        }
    }
}
