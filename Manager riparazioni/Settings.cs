using Manager_riparazioni.Util;
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

        /*
                Properties.Settings.Default.URI_Database
                Properties.Settings.Default.Username
                Properties.Settings.Default.Password
         */



        public Settings()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Load_Settings(object sender, EventArgs e)
        {
            textbox_db_uri.Text = Properties.Settings.Default.URI_Database;
            textbox_username.Text = Properties.Settings.Default.Username;
            textbox_password.Text = Properties.Settings.Default.Password;
            textbox_db_name.Text = Properties.Settings.Default.DB_Name;
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

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            textbox_password.PasswordChar = '*';
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {    
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
            try {
                isConnect = dbCon.IsConnect();
            } catch (Exception error)
            {
                EventLog.Exists("", error.Message);
            }
            ConnectionResult connectionResult = new ConnectionResult(isConnect);
            connectionResult.Show();
            dbCon.Disconnect();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
