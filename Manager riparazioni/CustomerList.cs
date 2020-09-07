using Manager_riparazioni.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            {
                LoadCustomerList();
            }
        }

        private void LoadCustomerList()
        {
            //isConnect is true
            string query = "" +
                "select * from " +
                Properties.Settings.Default.customers_table_name;

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
            customer.Show();
        }

        private void New_Repair_Click(object sender, EventArgs e)
        {
            Object customer_id = dataGridView1.CurrentRow.Cells[0].Value;
            Repair newRepair = new Repair(customer_id,null);
            newRepair.Show();
        }
        private void RowsSelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected_rows = dataGridView1.SelectedRows;
            if (selected_rows.Count != 1)
                button_new_repair.Enabled = false;            
            else
                button_new_repair.Enabled = true;
        }
    }
}
