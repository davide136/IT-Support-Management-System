using Manager_riparazioni.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class RepairsArchive : Form
    {
        readonly DBConnection dbConnection = DBConnection.Instance();
        private ArrayList customer_id;
        DataTable dataTable = new DataTable();


        public RepairsArchive()
        {
            InitializeComponent();
            customer_id = new ArrayList();

            dataTable.Columns.Add("Rep. ID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Date Start", typeof(string));
            dataTable.Columns.Add("Date End", typeof(string));
            dataTable.Columns.Add("Device", typeof(string));
            dataTable.Columns.Add("Objective", typeof(string));

            UpdateUI();
        }

        private void LoadList()
        {
            //isConnect is true

            string query = Properties.Settings.Default.query_load_repairs_list;
            var cmd = new MySqlCommand(query, dbConnection.Connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String repair_id = reader.GetString(0);
                String s1 = "", s2 = "", s3 = "";
                if (!reader.IsDBNull(1))
                    s1 = reader.GetString(1);
                if (!reader.IsDBNull(2))
                    s2 = reader.GetString(2);
                if (!reader.IsDBNull(3))
                    s3 = reader.GetString(3);
                string name = GetName(s1, s2, s3);

                String date_start = "";
                if (!reader.IsDBNull(4))
                {
                    date_start = reader.GetString(4);
                    string day = date_start.Substring(0, 2);
                    string month = date_start.Substring(3, 2);
                    string year = date_start.Substring(6, 4);
                    string hour = date_start.Substring(11, 2);
                    string minute = date_start.Substring(14, 2);
                    date_start = year + "/" + month + "/" + day + " " + hour + ":" + minute;
                }

                String date_end = "";
                if (!reader.IsDBNull(5))
                    date_end = reader.GetString(5);

                String device_model = "";
                if (!reader.IsDBNull(6))
                    device_model = reader.GetString(6);

                String objective = "";
                if (!reader.IsDBNull(7))
                    objective = reader.GetString(7);

                if (!reader.IsDBNull(8))
                    customer_id.Add(reader.GetString(8));

                dataTable.Rows.Add(
                    repair_id,
                    name,
                    date_start,
                    date_end,
                    device_model,
                    objective
                    );
            }

            dataGridView1.DataSource = dataTable;

            reader.Close();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeColumnHeadersHeight();
        }

        private string GetName(string name, string surname, string business)
        {
            String result = "";
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

        private void Row_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Object repair_index = dataGridView1.CurrentRow.Cells[0].Value;
            Repair customer = new Repair(customer_id[dataGridView1.CurrentRow.Index], repair_index);
            DialogResult result = customer.ShowDialog();
            if (result == DialogResult.OK)
                UpdateUI();
        }

        private void UpdateUI()
        {
            EmptyList();
            LoadList();
        }

        private void EmptyList()
        {
            dataTable.Clear();
        }

        private void textBox_filter_TextChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Format(
                "Name LIKE '%{0}%' OR " +
                "Device LIKE '%{0}%' OR " +
                "'Rep. ID' LIKE '%{0}%'",
                textBox_filter.Text);
        }

        private void RepairsFormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            Object repair_index = dataGridView1.CurrentRow.Cells[0].Value;
            Repair customer = new Repair(customer_id[dataGridView1.CurrentRow.Index], repair_index);
            DialogResult result = customer.ShowDialog();
            if (result == DialogResult.OK)
                UpdateUI();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            QueryDeleteRepair(dataGridView1.CurrentRow.Cells[0].Value + "");
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void QueryDeleteRepair(string repair_id)
        {
            string query = Properties.Settings.Default.query_repair_delete + repair_id;
            var cmd = new MySqlCommand(query, dbConnection.Connection);
            var reader = cmd.ExecuteReader();
            reader.Close();
        }
    }
}
