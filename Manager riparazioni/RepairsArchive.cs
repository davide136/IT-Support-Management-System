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
    public partial class RepairsArchive : Form
    {
        readonly DBConnection dbConnection = DBConnection.Instance();
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
                // REPAIR ID
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_id_repair +
                ", " +
                //NAME
                Properties.Settings.Default.customers_table_name +
                "." +
                Properties.Settings.Default.col_customer_name +
                ", " +
                //SURNNAME
                Properties.Settings.Default.customers_table_name +
                "." +
                Properties.Settings.Default.col_customer_surname +
                ", " +
                //BUSINESS NAME
                Properties.Settings.Default.customers_table_name +
                "." +
                Properties.Settings.Default.col_customer_business_name +
                ", " +
                //START
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_date_start +
                ", " +
                //END
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_date_end +
                ", " +
                //DEVICE MODEL
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_device_model +
                ", " +
                //OBJECTIVE
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_objective +
                " from " +
                //TABLE NAME
                Properties.Settings.Default.customers_table_name +
                ", " +
                Properties.Settings.Default.repairs_table_name ;

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

    }
}
