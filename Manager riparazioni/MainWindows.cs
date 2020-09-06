using Manager_riparazioni.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class MainWindows : Form
    {
        Boolean isConnect = false;
        DBConnection dbCon = DBConnection.Instance();

        public MainWindows()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnuExit_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();
            customerList.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Repair repair = new Repair();
            repair.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            RepairsArchive repairsArchive = new RepairsArchive();
            repairsArchive.Show();
        }

        private void Tools_clicked(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isConnect)
            {
                if (dbCon != null)
                {
                    dbCon.Disconnect();
                    EmptyList();
                    button5.Text = "Connect";
                    isConnect = false;
                }
            }
            else
            {
                try
                {
                    isConnect = dbCon.IsConnect();
                }
                catch (Exception error)
                {
                    EventLog.Exists("", error.Message);
                }
                if (isConnect)
                {
                    LoadList();
                    button5.Text = "Disconnect";
                }
            }
        }

        private void EmptyList()
        {
            //throw new NotImplementedException();
        }

        private void LoadList()
        {
            //throw new NotImplementedException();
        }
    }
}
