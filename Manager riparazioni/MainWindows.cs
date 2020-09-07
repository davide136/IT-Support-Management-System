using Manager_riparazioni.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
        readonly DBConnection dbConnection = DBConnection.Instance();

        public MainWindows()
        {
            InitializeComponent();
            label_uri.Text = Properties.Settings.Default.URI_Database;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpdateUI();
        }

        private void UpdateUI()
        {
            if (isConnect)
            {
                button_connect.Text = "Disconnect";
                label_status.Text = "CONNECTED";
                label_status.ForeColor = Color.Green;
            }
            else
            {
                button_connect.Text = "Connnect";
                label_status.Text = "NOT CONNECTED";
                label_status.ForeColor = Color.Red;
            }
            button_customers_list.Enabled = isConnect;
            button_new_customer.Enabled = isConnect;
            button_repairs__archive.Enabled = isConnect;
        }

        private void MnuExit_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();
            customerList.Show();
        }

        private void RepairsArchive_Click(object sender, EventArgs e)
        {
            RepairsArchive repairsArchive = new RepairsArchive();
            repairsArchive.Show();
        }

        private void Tools_clicked(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (isConnect)
            {
                if (dbConnection != null)
                {
                    dbConnection.Disconnect();
                    isConnect = false;
                    EmptyList();
                    UpdateUI();
                }
            }
            else
            {
                try
                {
                    isConnect = dbConnection.IsConnect();
                }
                catch (Exception error)
                {
                    EventLog.Exists("", error.Message);
                }
                if (isConnect)
                {
                    LoadList();
                    UpdateUI();
                }
            }
        }

        private void EmptyList()
        {
            dataGridView1.Rows.Clear();
        }

        private void LoadList()
        {
            //isConnect is true

            string query = "" +
                "select " +
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_id_repair +
                ", " +
                Properties.Settings.Default.customers_table_name +
                "." +
                Properties.Settings.Default.col_customer_name +
                ", " +
                Properties.Settings.Default.customers_table_name +
                "." +
                Properties.Settings.Default.col_customer_business_name +
                ", " +
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_device_model +
                ", " +
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_objective +
                ", " +
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_date_start +
                ", " +
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_result +
                " from " +
                Properties.Settings.Default.customers_table_name +
                ", " +
                Properties.Settings.Default.repairs_table_name +
                " where " +
                Properties.Settings.Default.col_repairs_id_customer +
                " = " +
                Properties.Settings.Default.col_customers_customer_id;

            var cmd = new MySqlCommand(query, dbConnection.Connection);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String repair_id = reader.GetString(0);
                String name = "";
                if (!reader.IsDBNull(1))
                    name = reader.GetString(1);

                String business_name = "";
                if (!reader.IsDBNull(2))
                    business_name = reader.GetString(2);
                              
                String device_model = "";
                if (!reader.IsDBNull(3))
                    device_model = reader.GetString(3);

                String objective = "";
                if (!reader.IsDBNull(4))
                    objective = reader.GetString(4);

                String date = "";
                if (!reader.IsDBNull(5))
                    date = reader.GetString(5);

                dataGridView1.Rows.Add(
                    repair_id,
                    name,
                    business_name,
                    device_model,
                    objective,
                    date
                    );
            }
            reader.Close();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeColumnHeadersHeight();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Object repair_index = dataGridView1.CurrentRow.Cells[0].Value;
            Repair repair = new Repair(null,repair_index);
            repair.Show();
        }
    }
}
