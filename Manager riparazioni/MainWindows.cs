using Manager_riparazioni.Util;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class MainWindows : Form
    {
        Boolean isConnect = false;
        private string customer_id;
        readonly DBConnection dbConnection = DBConnection.Instance();

        public MainWindows()
        {
            InitializeComponent();
            label_uri.Text = Properties.Settings.Default.URI_Database;
            UpdateUI();
            if (Properties.Settings.Default.autostart)
                Connect_Click(null, null);
        }

        private void UpdateUI()
        {
            if (isConnect)
            {
                button_connect.Text = "Disconnect";
                label_status.Text = "CONNECTED";
                label_status.ForeColor = Color.Green;

                EmptyList();
                LoadList();
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
            checkbox_hide_finnished.Enabled = isConnect;

        }

        private void MnuExit_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            DialogResult result = customer.ShowDialog();
            if (result == DialogResult.OK)
                UpdateUI();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();
            DialogResult result = customerList.ShowDialog();
            if (result == DialogResult.OK)
                UpdateUI();
        }

        private void RepairsArchive_Click(object sender, EventArgs e)
        {
            RepairsArchive repairsArchive = new RepairsArchive();
            DialogResult result = repairsArchive.ShowDialog();
            if (result == DialogResult.OK)
                UpdateUI();
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
                UpdateUI();
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
                // REPAIR ID  0
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_id_repair +
                ", " +
                //NAME  1
                Properties.Settings.Default.customers_table_name +
                "." +
                Properties.Settings.Default.col_customer_name +
                ", " +
                //SURNNAME  2
                Properties.Settings.Default.customers_table_name +
                "." +
                Properties.Settings.Default.col_customer_surname +
                ", " +
                //BUSINESS NAME  3
                Properties.Settings.Default.customers_table_name +
                "." +
                Properties.Settings.Default.col_customer_business_name +
                ", " +
                //START  4
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_date_start +
                ", " +
                //END  5
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_date_end +
                ", " +
                //DEVICE MODEL  6
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_device_model +
                ", " +
                //OBJECTIVE  7
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_objective +
                ", " +
                //CUSTOMER ID  8
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_id_customer +
                " from " +
                //TABLE NAME
                Properties.Settings.Default.customers_table_name +
                ", " +
                Properties.Settings.Default.repairs_table_name +
                " where " +
                //CONDITION
                Properties.Settings.Default.col_repairs_id_customer +
                " = " +
                Properties.Settings.Default.col_customers_customer_id;

            var cmd = new MySqlCommand(query, dbConnection.Connection);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string repair_id = reader.GetString(0);
                string name = "";
                string s1 = "", s2 = "", s3 = "";
                if (!reader.IsDBNull(1))
                    s1 = reader.GetString(1);
                if (!reader.IsDBNull(2))
                    s2 = reader.GetString(2);
                if (!reader.IsDBNull(3))
                    s3 = reader.GetString(3);
                name = GetName(s1, s2, s3);

                string date_start = "";
                if (!reader.IsDBNull(4))
                    date_start = reader.GetString(4);

                string date_end = "";
                if (!reader.IsDBNull(5))
                    date_end = reader.GetString(5);

                string device_model = "";
                if (!reader.IsDBNull(6))
                    device_model = reader.GetString(6);

                string objective = "";
                if (!reader.IsDBNull(7))
                    objective = reader.GetString(7);

                customer_id = "";
                if (!reader.IsDBNull(8))
                    customer_id = reader.GetString(8);


                dataGridView1.Rows.Add(
                    repair_id,
                    name,
                    date_start,
                    date_end,
                    device_model,
                    objective
                    );
            }
            reader.Close();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeColumnHeadersHeight();
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);

            checkbox_hide_finnished.Checked = true;
            checkbox_hide_finnished_CheckedChanged(null, null);
        }

        private string GetName(string name, string surname, string business)
        {
            string result = "";
            //has name or surname but no business name
            if (business == "" && (name != "" || surname != ""))
                result = surname + " " + name;
            //has name or surname and business name
            else if (business != "" && (name != "" || surname != ""))
                result = business + " Ref. " + name + " " + surname;
            //only has business name
            else if (business != "" && name == "" && surname == "")
                result = business;

            return result;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Object repair_index = dataGridView1.CurrentRow.Cells[0].Value;
            Repair repair = new Repair(customer_id, repair_index);
            DialogResult result = repair.ShowDialog();
            if (result == DialogResult.OK)
                UpdateUI();            
        }

        private void checkbox_hide_finnished_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
                if (dr.Cells[3].Value.ToString() != "")
                    dr.Visible = !checkbox_hide_finnished.Checked;
        }
    }
}
