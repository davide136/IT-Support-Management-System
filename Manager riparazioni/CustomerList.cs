using Manager_riparazioni.Util;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class CustomerList : Form
    {
        readonly DBConnection dBConnection = DBConnection.Instance();
        public CustomerList()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dBConnection.IsConnect())
                LoadCustomerList();

            button_new_repair.Enabled = false;
            button_edit_row.Enabled = false;
            button_delete_row.Enabled = false;
        }


        private void UpdateUI()
        {
            EmptyList();
            LoadCustomerList();
        }

        private void EmptyList()
        {
            dataGridView1.Rows.Clear();
        }

        private void LoadCustomerList()
        {
            //isConnect is true
            string query = Properties.Settings.Default.query_select_all_customers;

            var cmd = new MySqlCommand(query, dBConnection.Connection);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = reader.GetInt32(0);

                String name = "";
                if (!reader.IsDBNull(1))
                    name = reader.GetString(1);

                String surname = "";
                if (!reader.IsDBNull(2))
                    surname = reader.GetString(2);

                String type = "";
                if (!reader.IsDBNull(1))
                    type = reader.GetString(3);
                switch (type)
                {
                    case "0":
                        {
                            type = "Privato";
                            break;
                        }
                    case "1":
                        {
                            type = "Azienda";
                            break;
                        }
                    case "-1":
                        {
                            type = "";
                            break;
                        }

                }

                String business_name = "";
                if (!reader.IsDBNull(4))
                    business_name = reader.GetString(4);

                String date = "";
                if (!reader.IsDBNull(14))
                    date = reader.GetString(14);

                dataGridView1.Rows.Add(
                    index,
                    name,
                    surname,
                    type,
                    business_name,
                    date
                    );
            }
            reader.Close();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeColumnHeadersHeight();
        }

        private void New_Customer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            DialogResult result = customer.ShowDialog();
            if (result == DialogResult.OK)
                UpdateUI();
        }

        private void New_Repair_Click(object sender, EventArgs e)
        {
            Object customer_id = dataGridView1.CurrentRow.Cells[0].Value;
            Repair newRepair = new Repair(customer_id, null);
            DialogResult result = newRepair.ShowDialog();
            if (result == DialogResult.OK)
                UpdateUI();
        }

        private void RowsSelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected_rows = dataGridView1.SelectedRows;
            Boolean singleRowIsSelected = selected_rows.Count == 1;
            button_new_repair.Enabled = singleRowIsSelected;
            button_edit_row.Enabled = singleRowIsSelected;
            button_delete_row.Enabled = singleRowIsSelected;
        }

        private void GridView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Object customer_index = dataGridView1.CurrentRow.Cells[0].Value;
            Customer customer = new Customer(customer_index);
            DialogResult result = customer.ShowDialog();
            if (result == DialogResult.OK)
                UpdateUI();
        }

        private void button_edit_row_Click(object sender, EventArgs e)
        {
            Object customer_index = dataGridView1.CurrentRow.Cells[0].Value;
            Customer customer = new Customer(customer_index);
            DialogResult result = customer.ShowDialog();
            if (result == DialogResult.OK)
                UpdateUI();
        }

        private void button_delete_row_Click(object sender, EventArgs e)
        {
            Object customer_index = dataGridView1.CurrentRow.Cells[0].Value;
            QueryDeleteUserAndRepairs(customer_index);
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void QueryDeleteUserAndRepairs(object customer_index)
        {
            //isConnect is true
            string query =
                 Properties.Settings.Default.query_delete_user_repairs + customer_index.ToString();

            Debug.WriteLine("FIRST QUERY:    " + query);
            var cmd = new MySqlCommand(query, dBConnection.Connection);
            var reader = cmd.ExecuteReader();
            reader.Close();

            string query1 = Properties.Settings.Default.query_delete_user + customer_index.ToString();

            Debug.WriteLine("SECOND QUERY:    " + query1);
            var cmd1 = new MySqlCommand(query1, dBConnection.Connection);
            var reader1 = cmd1.ExecuteReader();
            reader1.Close();
        }

        private void CustomersListClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
