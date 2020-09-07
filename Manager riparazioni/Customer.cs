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
    public partial class Customer : Form
    {
        DBConnection dBConnection = DBConnection.Instance();
        public Customer()
        {
            InitializeComponent();
            button_save_and_exit.Enabled = false;
        }

        private void Save_and_exit_Click(object sender, EventArgs e)
        {
            
            if (dBConnection.IsConnect())
            {
                queryNewUser();          
            }
                                 
            this.Close();
        }

        private void queryNewUser()
        {
            String surname = textbox_surname.Text;
            String surname_col = "";
            if (surname != "")
            {
                surname = ",\"" + surname + "\"";
                surname_col =
                ",`"
                + Properties.Settings.Default.col_customer_surname + "`";
            }

            String type = combobox_clienttype.SelectedIndex.ToString();
            String type_col = "";
            if (type != "")
            {
                type = "," + type;
                type_col =
                 ",`"
                + Properties.Settings.Default.col_customer_type + "`";
            }

            String business_name = textBox_business_name.Text;
            String business_name_col = "";
            if (business_name != "")
            {
                business_name = ",\"" + business_name + "\"";
                business_name_col =
                 ",`"
                + Properties.Settings.Default.col_customer_business_name + "`";
            }

            String vat_id_1 = textBox_vat_id.Text;
            String vat_id_1_col = "";
            if (vat_id_1 != "")
            {
                vat_id_1 = ",\"" + vat_id_1 + "\"";
                vat_id_1_col =
                 ",`"
                + Properties.Settings.Default.col_customer_vat_id_1 + "`";
            }

            String vat_id_2 = textBox_vat_id_2.Text;
            String vat_id_2_col = "";
            if (vat_id_2 != "")
            {
                vat_id_2 = ",\"" + vat_id_2 + "\"";
                vat_id_2_col =
                 ",`"
                + Properties.Settings.Default.col_customer_vat_id_2 + "`";
            }

            String vat_id_3 = textBox_vat_id_3.Text;
            String vat_id_3_col = "";
            if (vat_id_3 != "")
            {
                vat_id_3 = ",\"" + vat_id_3 + "\"";
                vat_id_3_col =
                 ",`"
                + Properties.Settings.Default.col_customer_vat_id_3 + "`";
            }

            String address_street = textBox_address_route.Text;
            String address_street_col = "";
            if (address_street != "")
            {
                address_street = ",\"" + address_street + "\"";
                address_street_col =
                 ",`"
                + Properties.Settings.Default.col_customer_address_street + "`";
            }

            String number = textBox_address_number.Text;
            String number_col = "";
            if (number != "")
            {
                number = ",\"" + number + "\"";
                number_col =
                 ",`"
                + Properties.Settings.Default.col_customer_address_number + "`";
            }


            String city = textBox_address_city.Text;
            String city_col = "";
            if (city != "")
            {
                city = ",\"" + city + "\"";
                city_col =
                 ",`"
                + Properties.Settings.Default.col_customer_address_city + "`";
            }


            String region = textBox_address_region.Text;
            String region_col = "";
            if (region != "")
            {
                region = ",\"" + region + "\"";
                region_col =
                 ",`"
                + Properties.Settings.Default.col_customer_address_region + "`";
            }


            String phone = textBox_phone.Text;
            String phone_col = "";
            if (phone != "")
            {
                phone = ",\"" + phone + "\"";
                phone_col =
                 ",`"
                + Properties.Settings.Default.col_customer_phone + "`";
            }


            String mail = textBox_mail_address.Text;
            String mail_col = "";
            if (mail != "")
            {
                mail = ",\"" + mail + "\"";
                mail_col =
                 ",`"
                + Properties.Settings.Default.col_customer_mail_address + "`";
            }



            string query =
                "INSERT INTO `" + Properties.Settings.Default.customers_table_name
                + "` (`"
                + Properties.Settings.Default.col_customer_name
                + "`"
                + surname_col
                + type_col
                + business_name_col
                + vat_id_1_col
                + vat_id_2_col
                + vat_id_3_col
                + address_street_col
                + number_col
                + city_col
                + region_col
                + phone_col
                + mail_col
                + ") VALUES ("
                + '\u0022'
                + textbox_name.Text
                + '\u0022'
                + surname
                + type
                + business_name
                + vat_id_1
                + vat_id_2
                + vat_id_3
                + address_street
                + number
                + city
                + region
                + phone
                + mail
                + ')';
            var reader = new MySqlCommand(query, dBConnection.Connection).ExecuteReader();
            reader.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_name_TextChanged(object sender, EventArgs e)
        {
            button_save_and_exit.Enabled = !(textbox_name.Text.Length==0);
        }
    }
}
