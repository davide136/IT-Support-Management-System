using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class SetPrice : Form
    {
        public int Price { get; set; }

        public SetPrice()
        {
            InitializeComponent();
            button_save_and_exit.Enabled = false;
        }

        private void button_save_and_exit_Click(object sender, EventArgs e)
        {
            try { 
                Price = int.Parse(textBox_price_input.Text);
                this.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void textBox_price_input_TextChanged(object sender, EventArgs e)
        {
            button_save_and_exit.Enabled = !(textBox_price_input.Text.Length==0);
            try { Price = int.Parse(textBox_price_input.Text); }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                button_save_and_exit.Enabled = false;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
