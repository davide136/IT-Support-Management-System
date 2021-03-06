﻿using Manager_riparazioni.Util;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            textbox_db_uri.Text = Properties.Settings.Default.URI_Database;
            textbox_username.Text = Properties.Settings.Default.Username;
            textbox_password.Text = Properties.Settings.Default.Password;
            textbox_db_name.Text = Properties.Settings.Default.DB_Name;
            checkbox_autoconnect.Checked = Properties.Settings.Default.autostart;
        }


        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SaveAll();
            this.Close();
        }

        private void SaveAll()
        {
            Properties.Settings.Default.URI_Database = textbox_db_uri.Text;
            Properties.Settings.Default.Username = textbox_username.Text;
            Properties.Settings.Default.Password = textbox_password.Text;
            Properties.Settings.Default.DB_Name = textbox_db_name.Text;

            Properties.Settings.Default.Save();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveAll();
            //Test Connection
            var dbCon = DBConnection.Instance();
            Boolean isConnect = false;
            try
            {
                isConnect = dbCon.IsConnect();
            }
            catch (Exception error)
            {
                EventLog.Exists("", error.Message);
            }
            ConnectionResult connectionResult = new ConnectionResult(isConnect);
            connectionResult.Show();
            dbCon.Disconnect();
        }

        private void checkbox_autoconnect_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autostart = checkbox_autoconnect.Checked;
        }
    }
}
