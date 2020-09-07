namespace Manager_riparazioni
{
    partial class Repair
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
            this.textBox_device_model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_repairtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_objective = new System.Windows.Forms.RichTextBox();
            this.linklabel_repair_id = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_notes = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_end_repair = new System.Windows.Forms.Button();
            this.button_open_repair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_load_date = new System.Windows.Forms.Label();
            this.label_end_date = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_save_and_exit
            // 
            this.button_save_and_exit.Location = new System.Drawing.Point(911, 742);
            this.button_save_and_exit.Name = "button_save_and_exit";
            this.button_save_and_exit.Size = new System.Drawing.Size(175, 59);
            this.button_save_and_exit.TabIndex = 4;
            this.button_save_and_exit.Text = "Salva ed Esci";
            this.button_save_and_exit.UseVisualStyleBackColor = true;
            this.button_save_and_exit.Click += new System.EventHandler(this.Save_and_exit_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(715, 742);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(175, 59);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Annulla";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Riparazione";
            // 
            // textBox_device_model
            // 
            this.textBox_device_model.Location = new System.Drawing.Point(255, 136);
            this.textBox_device_model.Name = "textBox_device_model";
            this.textBox_device_model.Size = new System.Drawing.Size(440, 31);
            this.textBox_device_model.TabIndex = 1;
            this.textBox_device_model.TextChanged += new System.EventHandler(this.textBox_device_model_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modello Dispositivo";
            // 
            // comboBox_repairtype
            // 
            this.comboBox_repairtype.FormattingEnabled = true;
            this.comboBox_repairtype.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Vendita",
            "Preventivo"});
            this.comboBox_repairtype.Location = new System.Drawing.Point(255, 79);
            this.comboBox_repairtype.Name = "comboBox_repairtype";
            this.comboBox_repairtype.Size = new System.Drawing.Size(258, 33);
            this.comboBox_repairtype.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Difetto / Commissione";
            // 
            // richTextBox_objective
            // 
            this.richTextBox_objective.Location = new System.Drawing.Point(255, 215);
            this.richTextBox_objective.Name = "richTextBox_objective";
            this.richTextBox_objective.Size = new System.Drawing.Size(831, 127);
            this.richTextBox_objective.TabIndex = 2;
            this.richTextBox_objective.Text = "";
            // 
            // linklabel_repair_id
            // 
            this.linklabel_repair_id.AutoSize = true;
            this.linklabel_repair_id.Location = new System.Drawing.Point(932, 82);
            this.linklabel_repair_id.Name = "linklabel_repair_id";
            this.linklabel_repair_id.Size = new System.Drawing.Size(154, 25);
            this.linklabel_repair_id.TabIndex = 5;
            this.linklabel_repair_id.TabStop = true;
            this.linklabel_repair_id.Text = "Ticket Riparazione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Appunti";
            // 
            // textbox_notes
            // 
            this.textbox_notes.Location = new System.Drawing.Point(255, 370);
            this.textbox_notes.Name = "textbox_notes";
            this.textbox_notes.Size = new System.Drawing.Size(831, 210);
            this.textbox_notes.TabIndex = 3;
            this.textbox_notes.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 722);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data presa in carico";
            // 
            // button_end_repair
            // 
            this.button_end_repair.Location = new System.Drawing.Point(911, 624);
            this.button_end_repair.Name = "button_end_repair";
            this.button_end_repair.Size = new System.Drawing.Size(175, 59);
            this.button_end_repair.TabIndex = 6;
            this.button_end_repair.Text = "Termina Lavoro";
            this.button_end_repair.UseVisualStyleBackColor = true;
            // 
            // button_open_repair
            // 
            this.button_open_repair.Location = new System.Drawing.Point(715, 624);
            this.button_open_repair.Name = "button_open_repair";
            this.button_open_repair.Size = new System.Drawing.Size(175, 59);
            this.button_open_repair.TabIndex = 5;
            this.button_open_repair.Text = "Riapri Lavoro";
            this.button_open_repair.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 657);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Costo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 759);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data fine lavoro";
            // 
            // label_load_date
            // 
            this.label_load_date.AutoSize = true;
            this.label_load_date.Location = new System.Drawing.Point(364, 722);
            this.label_load_date.Name = "label_load_date";
            this.label_load_date.Size = new System.Drawing.Size(59, 25);
            this.label_load_date.TabIndex = 8;
            this.label_load_date.Text = "label9";
            // 
            // label_end_date
            // 
            this.label_end_date.AutoSize = true;
            this.label_end_date.Location = new System.Drawing.Point(364, 759);
            this.label_end_date.Name = "label_end_date";
            this.label_end_date.Size = new System.Drawing.Size(59, 25);
            this.label_end_date.TabIndex = 8;
            this.label_end_date.Text = "label9";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(364, 657);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(59, 25);
            this.label_price.TabIndex = 8;
            this.label_price.Text = "label9";
            // 
            // Repair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 846);
            this.Controls.Add(this.label_end_date);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_load_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linklabel_repair_id);
            this.Controls.Add(this.textbox_notes);
            this.Controls.Add(this.richTextBox_objective);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_repairtype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_device_model);
            this.Controls.Add(this.button_open_repair);
            this.Controls.Add(this.button_end_repair);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save_and_exit);
            this.Name = "Repair";
            this.Text = "Riparazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save_and_exit;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_device_model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_repairtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_objective;
        private System.Windows.Forms.LinkLabel linklabel_repair_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox textbox_notes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_end_repair;
        private System.Windows.Forms.Button button_open_repair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_load_date;
        private System.Windows.Forms.Label label_end_date;
        private System.Windows.Forms.Label label_price;
    }
}