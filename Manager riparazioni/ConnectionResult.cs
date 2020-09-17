using System;
using System.Drawing;
using System.Windows.Forms;

namespace Manager_riparazioni
{
    public partial class ConnectionResult : Form
    {
        public ConnectionResult(Boolean result)
        {
            InitializeComponent();
            if (result)
            {
                label1.Text = "CONNECTION SUCCESSFUL!";
                label1.ForeColor = Color.Green;
            }
            else
            {

                label1.Text = "CONNECTION FAILED!";
                label1.ForeColor = Color.Red;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
