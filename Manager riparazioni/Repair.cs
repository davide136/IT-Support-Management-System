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
    public partial class Repair : Form
    {
        Object customer_id;
        Object repair_id;
        DBConnection dBConnection = DBConnection.Instance();

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
            string query = "" +
                "select " +
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_type +
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
                Properties.Settings.Default.col_repairs_notes +
                ", " +
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_date_start +
                ", " +
                Properties.Settings.Default.repairs_table_name +
                "." +
                Properties.Settings.Default.col_repairs_result +
                " from " +
                Properties.Settings.Default.repairs_table_name +
                " where " +
                Properties.Settings.Default.col_repairs_id_repair +
                " = " +
                repair_id.ToString() ;

            var cmd = new MySqlCommand(query, dBConnection.Connection);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {                
                String type = "";
                if (!reader.IsDBNull(0))
                    type = reader.GetString(0);

                String device_model = "";
                if (!reader.IsDBNull(1))
                    device_model = reader.GetString(1);

                String objective = "";
                if (!reader.IsDBNull(2))
                    objective = reader.GetString(2);


                String notes = "";
                if (!reader.IsDBNull(3))
                    notes = reader.GetString(3);

                String load_date = "";
                if (!reader.IsDBNull(4))
                    load_date = reader.GetString(4);

                comboBox_repairtype.SelectedItem = type;
                textBox_device_model.Text = device_model;
                richTextBox_objective.Text = objective;
                textbox_notes.Text = notes;
                label_load_date.Text = load_date;
            }
            reader.Close();
        }

        private void Save_and_exit_Click(object sender, EventArgs e)
        {
            if (dBConnection.IsConnect())
            {
                if(repair_id==null)
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
            String repair_type_col = "";
            if (repair_type != "")
            {
                repair_type = "`=\"" + repair_type + "\",";
                repair_type_col = "`" + Properties.Settings.Default.col_repairs_type;
            }

            String objective = richTextBox_objective.Text;
            String objective_col = "";
            if (objective != "")
            {
                objective = "`=\"" + objective + "\",";
                objective_col = "`" + Properties.Settings.Default.col_repairs_objective;
            }

            String notes = textbox_notes.Text;
            String notes_col = "";
            if (notes != "")
            {
                notes = "`=\"" + notes + "\"";
                notes_col = "`" + Properties.Settings.Default.col_repairs_notes;
            }




            string query =
                "UPDATE `" + Properties.Settings.Default.repairs_table_name
                + "` SET `"
                 + Properties.Settings.Default.col_repairs_device_model + "`=\"" + device_model + "\","
                 + repair_type_col + repair_type
                 + objective_col + objective
                 + notes_col + notes
                 + " WHERE `"
                 + Properties.Settings.Default.col_repairs_id_repair 
                 + "`="
                 +repair_id.ToString();

            var reader = new MySqlCommand(query, dBConnection.Connection).ExecuteReader();
            reader.Close();
        }

        private void queryNewRepair()
        {
            String repair_type = comboBox_repairtype.SelectedIndex.ToString();
            String repair_type_col = "";
            if (repair_type != "")
            {
                repair_type = "," + repair_type;
                repair_type_col =
                 ",`"
                + Properties.Settings.Default.col_repairs_type + "`";
            }


            String device_model = textBox_device_model.Text;
            String device_model_col = "";
            if (device_model != "")
            {
                device_model = ",\"" + device_model + "\"";
                device_model_col =
                ",`"
                + Properties.Settings.Default.col_repairs_device_model + "`";
            }            
          

            String objective = richTextBox_objective.Text;
            String objective_col = "";
            if (objective != "")
            {
                objective = ",\"" + objective + "\"";
                objective_col =
                 ",`"
                + Properties.Settings.Default.col_repairs_objective + "`";
            }

            String notes = textbox_notes.Text;
            String notes_col = "";
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
            var reader = new MySqlCommand(query, dBConnection.Connection).ExecuteReader();
            reader.Close();
        }

        private void textBox_device_model_TextChanged(object sender, EventArgs e)
        {
            if (textBox_device_model.TextLength != 0)
                button_save_and_exit.Enabled = true;
            else button_save_and_exit.Enabled = false;
        }
    }
}
