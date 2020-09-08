namespace Manager_riparazioni
{
    partial class SetPrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_price_input = new System.Windows.Forms.TextBox();
            this.button_save_and_exit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserire Prezzo";
            // 
            // textBox_price_input
            // 
            this.textBox_price_input.Location = new System.Drawing.Point(238, 51);
            this.textBox_price_input.Name = "textBox_price_input";
            this.textBox_price_input.Size = new System.Drawing.Size(150, 31);
            this.textBox_price_input.TabIndex = 1;
            this.textBox_price_input.TextChanged += new System.EventHandler(this.textBox_price_input_TextChanged);
            // 
            // button_save_and_exit
            // 
            this.button_save_and_exit.Location = new System.Drawing.Point(238, 109);
            this.button_save_and_exit.Name = "button_save_and_exit";
            this.button_save_and_exit.Size = new System.Drawing.Size(150, 47);
            this.button_save_and_exit.TabIndex = 2;
            this.button_save_and_exit.Text = "Salva";
            this.button_save_and_exit.UseVisualStyleBackColor = true;
            this.button_save_and_exit.Click += new System.EventHandler(this.button_save_and_exit_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(46, 109);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(150, 47);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancella";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // SetPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 182);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save_and_exit);
            this.Controls.Add(this.textBox_price_input);
            this.Controls.Add(this.label1);
            this.Name = "SetPrice";
            this.Text = "SetPrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_price_input;
        private System.Windows.Forms.Button button_save_and_exit;
        private System.Windows.Forms.Button button_cancel;
    }
}