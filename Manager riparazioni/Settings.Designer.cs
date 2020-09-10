namespace Manager_riparazioni
{
    partial class Settings
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
            this.button_save_and_exit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_db_uri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.button_test = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_db_name = new System.Windows.Forms.TextBox();
            this.checkbox_autoconnect = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_save_and_exit
            // 
            this.button_save_and_exit.Location = new System.Drawing.Point(581, 380);
            this.button_save_and_exit.Name = "button_save_and_exit";
            this.button_save_and_exit.Size = new System.Drawing.Size(223, 67);
            this.button_save_and_exit.TabIndex = 6;
            this.button_save_and_exit.Text = "Salva ed Esci";
            this.button_save_and_exit.UseVisualStyleBackColor = true;
            this.button_save_and_exit.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(332, 380);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(223, 67);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Annulla";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "URI Database";
            // 
            // textbox_db_uri
            // 
            this.textbox_db_uri.Location = new System.Drawing.Point(214, 59);
            this.textbox_db_uri.Name = "textbox_db_uri";
            this.textbox_db_uri.Size = new System.Drawing.Size(576, 31);
            this.textbox_db_uri.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Utente";
            // 
            // textbox_username
            // 
            this.textbox_username.Location = new System.Drawing.Point(214, 171);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(274, 31);
            this.textbox_username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(214, 217);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(274, 31);
            this.textbox_password.TabIndex = 4;
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(531, 217);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(112, 34);
            this.button_test.TabIndex = 5;
            this.button_test.Text = "Test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome DB";
            // 
            // textbox_db_name
            // 
            this.textbox_db_name.Location = new System.Drawing.Point(215, 109);
            this.textbox_db_name.Name = "textbox_db_name";
            this.textbox_db_name.Size = new System.Drawing.Size(274, 31);
            this.textbox_db_name.TabIndex = 2;
            // 
            // checkbox_autoconnect
            // 
            this.checkbox_autoconnect.AutoSize = true;
            this.checkbox_autoconnect.Location = new System.Drawing.Point(51, 295);
            this.checkbox_autoconnect.Name = "checkbox_autoconnect";
            this.checkbox_autoconnect.Size = new System.Drawing.Size(190, 29);
            this.checkbox_autoconnect.TabIndex = 8;
            this.checkbox_autoconnect.Text = "Connect on startup";
            this.checkbox_autoconnect.UseVisualStyleBackColor = true;
            this.checkbox_autoconnect.CheckedChanged += new System.EventHandler(this.checkbox_autoconnect_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 504);
            this.Controls.Add(this.checkbox_autoconnect);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_db_name);
            this.Controls.Add(this.textbox_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_db_uri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save_and_exit);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save_and_exit;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_db_uri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_db_name;
        private System.Windows.Forms.CheckBox checkbox_autoconnect;
    }
}