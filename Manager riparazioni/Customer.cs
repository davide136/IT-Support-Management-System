using Manager_riparazioni.Util;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class Customer : Form
    {
        DBConnection dBConnection = DBConnection.Instance();
        private object customer_index;

        public Customer()
        {
            InitializeComponent();
            button_save_and_exit.Enabled = false;

        }

        private void LoadData()
        {
            string query = "" +
                "select * from " +
                Properties.Settings.Default.customers_table_name +
                " where " +
                Properties.Settings.Default.col_customers_customer_id +
                " = " +
                customer_index.ToString();

            Debug.WriteLine("Load query: " + query);

            var cmd = new MySqlCommand(query, dBConnection.Connection);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String index = reader.GetString(0);

                String name = "";
                if (!reader.IsDBNull(1))
                    name = reader.GetString(1);

                String surname = "";
                if (!reader.IsDBNull(2))
                    surname = reader.GetString(2);


                String type = "";
                if (!reader.IsDBNull(3))
                    type = reader.GetString(3);

                String business_name = "";
                if (!reader.IsDBNull(4))
                    business_name = reader.GetString(4);

                String vat_id_1 = "";
                if (!reader.IsDBNull(5))
                    vat_id_1 = reader.GetString(5);

                String vat_id_2 = "";
                if (!reader.IsDBNull(6))
                    vat_id_2 = reader.GetString(6);

                String vat_id_3 = "";
                if (!reader.IsDBNull(7))
                    vat_id_3 = reader.GetString(7);

                String address_street = "";
                if (!reader.IsDBNull(8))
                    address_street = reader.GetString(8);

                String address_number = "";
                if (!reader.IsDBNull(9))
                    address_number = reader.GetString(9);

                String address_city = "";
                if (!reader.IsDBNull(10))
                    address_city = reader.GetString(10);

                String address_region = "";
                if (!reader.IsDBNull(11))
                    address_region = reader.GetString(11);

                String phone = "";
                if (!reader.IsDBNull(12))
                    phone = reader.GetString(12);

                String mail_address = "";
                if (!reader.IsDBNull(13))
                    mail_address = reader.GetString(13);

                linkLabel1.Text = "#" + index;
                textbox_name.Text = name;
                textbox_surname.Text = surname;
                combobox_clienttype.SelectedIndex = int.Parse(type);
                textBox_business_name.Text = business_name;
                textBox_vat_id.Text = vat_id_1;
                textBox_vat_id_2.Text = vat_id_2;
                textBox_vat_id_3.Text = vat_id_3;
                textBox_address_route.Text = address_street;
                textBox_address_number.Text = address_number;
                textBox_address_city.Text = address_city;
                textBox_phone.Text = phone;
                textBox_mail_address.Text = mail_address;

            }
            reader.Close();
        }

        public Customer(object customer_index)
        {
            InitializeComponent();
            button_save_and_exit.Enabled = false;
            this.customer_index = customer_index;
            LoadData();
        }

        private void Save_and_exit_Click(object sender, EventArgs e)
        {

            if (dBConnection.IsConnect())
            {
                if (customer_index == null)
                    queryNewUser();
                else
                    updateUser();
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
        private void updateUser()
        {
            String surname = textbox_surname.Text;
            String surname_col = "";
            String type = combobox_clienttype.SelectedIndex.ToString();
            String type_col = "";
            String business_name = textBox_business_name.Text;
            String business_name_col = "";
            String vat_id_1 = textBox_vat_id.Text;
            String vat_id_1_col = "";
            String vat_id_2 = textBox_vat_id_2.Text;
            String vat_id_2_col = "";
            String vat_id_3 = textBox_vat_id_3.Text;
            String vat_id_3_col = "";
            String address_street = textBox_address_route.Text;
            String address_street_col = "";
            String number = textBox_address_number.Text;
            String number_col = "";
            String city = textBox_address_city.Text;
            String city_col = "";
            String region = textBox_address_region.Text;
            String region_col = "";
            String phone = textBox_phone.Text;
            String phone_col = "";
            String mail = textBox_mail_address.Text;
            String mail_col = "";

            if (surname != "")
            {
                surname = "\"" + surname + "\"";
                surname_col =
                ",`"
                + Properties.Settings.Default.col_customer_surname + "`=";
            }

            if (type != "")
            {
                type_col =
                 ",`"
                + Properties.Settings.Default.col_customer_type + "`=";
            }

            if (business_name != "")
            {
                business_name = "\"" + business_name + "\"";
                business_name_col =
                 ",`"
                + Properties.Settings.Default.col_customer_business_name + "`=";
            }

            if (vat_id_1 != "")
            {
                vat_id_1 = "\"" + vat_id_1 + "\"";
                vat_id_1_col =
                 ",`"
                + Properties.Settings.Default.col_customer_vat_id_1 + "`=";
            }

            if (vat_id_2 != "")
            {
                vat_id_2 = "\"" + vat_id_2 + "\"";
                vat_id_2_col =
                 ",`"
                + Properties.Settings.Default.col_customer_vat_id_2 + "`=";
            }

            if (vat_id_3 != "")
            {
                vat_id_3 = "\"" + vat_id_3 + "\"";
                vat_id_3_col =
                 ",`"
                + Properties.Settings.Default.col_customer_vat_id_3 + "`=";
            }

            if (address_street != "")
            {
                address_street = "\"" + address_street + "\"";
                address_street_col =
                 ",`"
                + Properties.Settings.Default.col_customer_address_street + "`=";
            }
            if (number != "")
            {
                number = "\"" + number + "\"";
                number_col =
                 ",`"
                + Properties.Settings.Default.col_customer_address_number + "`=";
            }


            if (city != "")
            {
                city = "\"" + city + "\"";
                city_col =
                 ",`"
                + Properties.Settings.Default.col_customer_address_city + "`=";
            }


            if (region != "")
            {
                region = "\"" + region + "\"";
                region_col =
                 ",`"
                + Properties.Settings.Default.col_customer_address_region + "`=";
            }


            if (phone != "")
            {
                phone = "\"" + phone + "\"";
                phone_col =
                 ",`"
                + Properties.Settings.Default.col_customer_phone + "`=";
            }


            if (mail != "")
            {
                mail = "\"" + mail + "\"";
                mail_col =
                 ",`"
                + Properties.Settings.Default.col_customer_mail_address + "`=";
            }



            string query =
                "UPDATE `" + Properties.Settings.Default.customers_table_name
                + "` SET `"
                + Properties.Settings.Default.col_customer_name
                + "`="
                + '\"'
                + textbox_name.Text
                + '\"'
                + surname_col
                + surname
                + type_col
                + type
                + business_name_col
                + business_name
                + vat_id_1_col
                + vat_id_1
                + vat_id_2_col
                + vat_id_2
                + vat_id_3_col
                + vat_id_3
                + address_street_col
                + address_street
                + number_col
                + number
                + city_col
                + city
                + region_col
                + region
                + phone_col
                + phone
                + mail_col
                + mail
                 + " WHERE `"
                 + Properties.Settings.Default.col_customers_customer_id
                 + "`="
                 + customer_index.ToString();
            Debug.WriteLine(query);
            var reader = new MySqlCommand(query, dBConnection.Connection).ExecuteReader();
            reader.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_name_TextChanged(object sender, EventArgs e)
        {
            button_save_and_exit.Enabled = !(textbox_name.Text.Length == 0);
        }

        private void CustomerClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
