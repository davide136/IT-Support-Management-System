using Manager_riparazioni.Util;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class RepairsArchive : Form
    {
        readonly DBConnection dbConnection = DBConnection.Instance();
        private string customer_id;

        public RepairsArchive()
        {
            InitializeComponent();
            LoadList();
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
                //DEVICE MODEL 6
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
                " WHERE " +
                Properties.Settings.Default.customers_table_name + "." +
                Properties.Settings.Default.col_customers_customer_id + " = " +

                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_id_customer 
                ;


            Debug.WriteLine(query);
            var cmd = new MySqlCommand(query, dbConnection.Connection);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String repair_id = reader.GetString(0);
                String name = "";
                String s1 = "", s2 = "", s3 = "";
                if (!reader.IsDBNull(1))
                    s1 = reader.GetString(1);
                if (!reader.IsDBNull(2))
                    s2 = reader.GetString(2);
                if (!reader.IsDBNull(3))
                    s3 = reader.GetString(3);
                name = GetName(s1, s2, s3);

                String date_start = "";
                if (!reader.IsDBNull(4))
                    date_start = reader.GetString(4);

                String date_end = "";
                if (!reader.IsDBNull(5))
                    date_end = reader.GetString(5);

                String device_model = "";
                if (!reader.IsDBNull(6))
                    device_model = reader.GetString(6);

                String objective = "";
                if (!reader.IsDBNull(7))
                    objective = reader.GetString(7);

                if (!reader.IsDBNull(7))
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
            dataGridView1.Sort(dataGridView1.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
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
            Repair repair = new Repair(customer_id, repair_index);
            repair.Show();
        }

        private void textBox_filter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(
                col_date_end + " like '{0}%' OR "
                + col_date + " like '{0}%' OR "
                + col_device + " like '{0}%' OR "
                + col_obj + " like '{0}%' OR "
                + col_name + " like '{0}%'",
                textBox_filter.Text);
            }
            catch (Exception error) { Debug.WriteLine(error.Message); };
        }
    }
}
