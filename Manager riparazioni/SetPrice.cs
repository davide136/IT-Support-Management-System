using System;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class SetPrice : Form
    {
        public String Price { get; set; }

        public TextBox Textbox_price { get; set; }

        public SetPrice()
        {
            InitializeComponent();
            button_save_and_exit.Enabled = false;

        }

        private void button_save_and_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox_price_input_TextChanged(object sender, EventArgs e)
        {
            button_save_and_exit.Enabled = !(textBox_price_input.Text.Length == 0);
            try
            {
                int temp = int.Parse(textBox_price_input.Text);
                Textbox_price = textBox_price_input;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                button_save_and_exit.Enabled = false;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
