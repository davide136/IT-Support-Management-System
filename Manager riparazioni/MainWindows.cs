using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class MainWindows : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();
            customerList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Repair repair = new Repair();
            repair.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RepairsArchive repairsArchive = new RepairsArchive();
            repairsArchive.Show();
        }

        private void tools_clicked(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
