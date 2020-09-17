using Manager_riparazioni.Util;
using MySql.Data.MySqlClient;
using OpenHtmlToPdf;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class Repair : Form
    {
        object customer_id;
        object repair_id;
        DBConnection dBConnection = DBConnection.Instance();
        string price = "";
        string end_date = "";

        public Repair(Object customer_id, Object repair_id)
        {
            InitializeComponent();
            this.customer_id = customer_id;
            this.repair_id = repair_id;
            if (repair_id != null)
                LoadData();
        }

        private void LoadData()
        {
            string case_existing = "";
            if ((string)customer_id != "")
                case_existing =
                 " AND " +

                Properties.Settings.Default.customers_table_name + "." +
                Properties.Settings.Default.col_customers_customer_id +
                " = " +
                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_id_customer;

            string query = "" +
                "select " +

                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_type + //0
                ", " +
                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_device_model + //1
                ", " +
                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_objective + //2
                ", " +
                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_notes + //3
                ", " +
                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_date_start + //4
                ", " +
                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_date_end + //5
                ", " +
                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_price + //6
                ", " +
                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_id_repair + //7
                ", " +
                Properties.Settings.Default.customers_table_name + "." +
                Properties.Settings.Default.col_customer_name + //8
                ", " +
                Properties.Settings.Default.customers_table_name + "." +
                Properties.Settings.Default.col_customer_surname + //9
                ", " +
                Properties.Settings.Default.customers_table_name + "." +
                Properties.Settings.Default.col_customer_business_name + //10
                ", " +
                Properties.Settings.Default.repairs_table_name + "." +
                Properties.Settings.Default.col_repairs_id_customer + //11

                " from " +
                Properties.Settings.Default.repairs_table_name + "," + Properties.Settings.Default.customers_table_name +
                " where " +

                Properties.Settings.Default.col_repairs_id_repair +
                " = " +
                repair_id.ToString() +
                case_existing;

            Debug.WriteLine("Load query: " + query);

            var cmd = new MySqlCommand(query, dBConnection.Connection);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string type = "";
                if (!reader.IsDBNull(0))
                    type = reader.GetString(0);

                string device_model = "";
                if (!reader.IsDBNull(1))
                    device_model = reader.GetString(1);

                string objective = "";
                if (!reader.IsDBNull(2))
                    objective = reader.GetString(2);


                string notes = "";
                if (!reader.IsDBNull(3))
                    notes = reader.GetString(3);

                string load_date = "";
                if (!reader.IsDBNull(4))
                    load_date = reader.GetString(4);

                string date_end = "";
                if (!reader.IsDBNull(5))
                    date_end = reader.GetString(5);

                string lb_price = "";
                if (!reader.IsDBNull(6))
                    lb_price = reader.GetString(6);

                string id = "";
                if (!reader.IsDBNull(7))
                    id = reader.GetString(7);

                string name = "";
                if (!reader.IsDBNull(8))
                    name = reader.GetString(8);
                string surname = "";
                if (!reader.IsDBNull(9))
                    surname = reader.GetString(9);
                string business = "";
                if (!reader.IsDBNull(10))
                    business = reader.GetString(10);
                string finalName = GetName(name, surname, business);


                if (!reader.IsDBNull(11))
                    customer_id = reader.GetString(11);

                comboBox_repairtype.SelectedIndex = int.Parse(type);
                textBox_device_model.Text = device_model;
                richTextBox_objective.Text = objective;
                textbox_notes.Text = notes;
                label_load_date.Text = load_date;
                label_end_date.Text = date_end;
                label_price.Text = lb_price;
                linklabel_repair_id.Text = id;
                linkLabel_customer_name.Text = finalName;
            }
            reader.Close();
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

        private void Save_and_exit_Click(object sender, EventArgs e)
        {
            if (dBConnection.IsConnect())
            {
                if (repair_id == null)
                    queryNewRepair();
                if (customer_id == null)
                    queryUpdateRepair();
            }
            this.Close();
        }

        private void queryUpdateRepair()
        {
            String device_model = textBox_device_model.Text;
            String repair_type = comboBox_repairtype.SelectedIndex.ToString();
            String objective = richTextBox_objective.Text;
            String notes = textbox_notes.Text;

            String repair_type_col = "";
            String objective_col = "";
            String notes_col = "";
            String end_date_col = "";
            String price_col = "";

            if (repair_type != "")
            {
                if (end_date != "" || price != "" || notes != "" || objective != "")
                    repair_type = "`=\"" + repair_type + "\",";
                else
                    repair_type = "`=\"" + repair_type + "\"";

                repair_type_col = "`" + Properties.Settings.Default.col_repairs_type;
            }

            if (objective != "")
            {
                if (end_date != "" || price != "" || notes != "")
                    objective = "`=\"" + objective + "\",";
                else
                    objective = "`=\"" + objective + "\"";
                objective_col = "`" + Properties.Settings.Default.col_repairs_objective;
            }

            if (notes != "")
            {
                if (end_date != "" || price != "")
                    notes = "`=\"" + notes + "\",";
                else
                    notes = "`=\"" + notes + "\"";
                notes_col = "`" + Properties.Settings.Default.col_repairs_notes;
            }

            if (end_date != "" && !price.Contains("€"))
                price = "`=\"€ " + price + "\",";
            if (end_date == "" && !price.Contains("€") && price != "")
                price = "`=\"" + price + "\"";
            if (price != "" && price_col == "")
                price_col = "`" + Properties.Settings.Default.col_repairs_price;


            if (end_date != "")
            {
                end_date = "`=\"" + end_date + "\"";
                end_date_col = "`" + Properties.Settings.Default.col_repairs_date_end;
            }


            string query =
                "UPDATE `" + Properties.Settings.Default.repairs_table_name
                + "` SET `"
                 + Properties.Settings.Default.col_repairs_device_model + "`=\"" + device_model + "\","
                 + repair_type_col + repair_type
                 + objective_col + objective
                 + notes_col + notes
                 + price_col + price
                 + end_date_col + end_date
                 + " WHERE `"
                 + Properties.Settings.Default.col_repairs_id_repair
                 + "`="
                 + repair_id.ToString();
            Debug.WriteLine("Update Query: " + query);
            var reader = new MySqlCommand(query, dBConnection.Connection).ExecuteReader();
            reader.Close();
            price = "";
        }

        private void queryNewRepair()
        {
            String repair_type = comboBox_repairtype.SelectedIndex.ToString();
            String objective = richTextBox_objective.Text;
            String device_model = textBox_device_model.Text;
            String notes = textbox_notes.Text;

            String repair_type_col = "";
            String device_model_col = "";
            String objective_col = "";
            String notes_col = "";

            if (repair_type != "")
            {
                repair_type = "," + repair_type;
                repair_type_col =
                 ",`"
                + Properties.Settings.Default.col_repairs_type + "`";
            }

            if (objective != "")
            {
                objective = ",\"" + objective + "\"";
                objective_col =
                 ",`"
                + Properties.Settings.Default.col_repairs_objective + "`";
            }


            if (notes != "")
            {
                notes = ",\"" + notes + "\"";
                notes_col =
                 ",`"
                + Properties.Settings.Default.col_repairs_notes + "`";
            }

            string query =
                "INSERT INTO `" + Properties.Settings.Default.repairs_table_name
                + "` (`"
                + Properties.Settings.Default.col_repairs_device_model
                + "`"
                + repair_type_col
                + objective_col
                + notes_col
                + ",`"
                + Properties.Settings.Default.col_repairs_id_customer
                + "`"
                + ") VALUES ("
                + '"'
                + textBox_device_model.Text
                + '"'
                + repair_type
                + objective
                + notes
                + ","
                + customer_id
                + ')';

            Debug.WriteLine(query);
            var reader = new MySqlCommand(query, dBConnection.Connection).ExecuteReader();
            reader.Close();
        }

        private void textBox_device_model_TextChanged(object sender, EventArgs e)
        {
            if (textBox_device_model.TextLength != 0)
                button_save_and_exit.Enabled = true;
            else button_save_and_exit.Enabled = false;
        }

        private void button_end_repair_Click(object sender, EventArgs e)
        {
            ShowSetPriceBox();
            end_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            queryUpdateRepair();
            end_date = "";
        }

        public void ShowSetPriceBox()
        {
            SetPrice testDialog = new SetPrice();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                price = testDialog.Textbox_price.Text;
            }
            testDialog.Dispose();
        }

        private void Print_Click(object sender, EventArgs e)
        {

            string html = "<!DOCTYPE html>" +
    "<html>" +
    "<head><meta charset='UTF-8'><title>Title</title></head>" +
    "<body>Body text...</body>" +
    "</html>";
            var pdf = Pdf
                .From(html)
                .OfSize(PaperSize.A4)
                .WithTitle("Title")
                .WithoutOutline()
                .WithMargins(1.25.Centimeters())
                .Portrait()
                .Comressed()
                .Content();

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "Client NAME.pdf";
            dlg.Filter = "PDF Document|pdf";
            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Open document 
                var filename = dlg.FileName;
                if (!filename.Contains(".pdf"))
                    filename += ".pdf";
                var file = File.Open(filename, FileMode.OpenOrCreate);
                var plik = new BinaryWriter(file);
                plik.Write(pdf);
                plik.Close();
            }
        }

        private void linkLabel_customer_name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer customer = new Customer(customer_id);
            customer.Show();
        }
    }
}