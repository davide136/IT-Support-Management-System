using System.Windows.Forms;

namespace Manager_riparazioni
{
    partial class MainWindows
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
            this.button_new_customer = new System.Windows.Forms.Button();
            this.button_customers_list = new System.Windows.Forms.Button();
            this.button_repairs__archive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_uri = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repair_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_business_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_obj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_new_customer
            // 
            this.button_new_customer.Location = new System.Drawing.Point(60, 677);
            this.button_new_customer.Name = "button_new_customer";
            this.button_new_customer.Size = new System.Drawing.Size(178, 74);
            this.button_new_customer.TabIndex = 1;
            this.button_new_customer.Text = "Nuovo Cliente";
            this.button_new_customer.UseVisualStyleBackColor = true;
            this.button_new_customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // button_customers_list
            // 
            this.button_customers_list.Location = new System.Drawing.Point(309, 677);
            this.button_customers_list.Name = "button_customers_list";
            this.button_customers_list.Size = new System.Drawing.Size(178, 74);
            this.button_customers_list.TabIndex = 2;
            this.button_customers_list.Text = "Elenco Clienti";
            this.button_customers_list.UseVisualStyleBackColor = true;
            this.button_customers_list.Click += new System.EventHandler(this.CustomerList_Click);
            // 
            // button_repairs__archive
            // 
            this.button_repairs__archive.Location = new System.Drawing.Point(1180, 677);
            this.button_repairs__archive.Name = "button_repairs__archive";
            this.button_repairs__archive.Size = new System.Drawing.Size(178, 74);
            this.button_repairs__archive.TabIndex = 3;
            this.button_repairs__archive.Text = "Archivio Riparazioni";
            this.button_repairs__archive.UseVisualStyleBackColor = true;
            this.button_repairs__archive.Click += new System.EventHandler(this.RepairsArchive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "DB URI:";
            // 
            // label_uri
            // 
            this.label_uri.AutoSize = true;
            this.label_uri.Location = new System.Drawing.Point(163, 84);
            this.label_uri.Name = "label_uri";
            this.label_uri.Size = new System.Drawing.Size(40, 25);
            this.label_uri.TabIndex = 3;
            this.label_uri.TabStop = true;
            this.label_uri.Text = "URI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "STATO:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(163, 125);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(72, 25);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "STATUS";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(949, 84);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(409, 74);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connetti";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(141, 34);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.MnuExit_Clicked);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.Tools_clicked);
            // 
            // repair_id
            // 
            this.repair_id.HeaderText = "repair_id";
            this.repair_id.MinimumWidth = 8;
            this.repair_id.Name = "repair_id";
            this.repair_id.ReadOnly = true;
            this.repair_id.Visible = false;
            this.repair_id.Width = 150;
            // 
            // col_name
            // 
            this.col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_name.HeaderText = "Name";
            this.col_name.MinimumWidth = 8;
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_business_name
            // 
            this.col_business_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_business_name.HeaderText = "Business Name";
            this.col_business_name.MinimumWidth = 8;
            this.col_business_name.Name = "col_business_name";
            this.col_business_name.ReadOnly = true;
            this.col_business_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_device
            // 
            this.col_device.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_device.HeaderText = "Device Model";
            this.col_device.MinimumWidth = 8;
            this.col_device.Name = "col_device";
            this.col_device.ReadOnly = true;
            this.col_device.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_obj
            // 
            this.col_obj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_obj.HeaderText = "Objective";
            this.col_obj.MinimumWidth = 8;
            this.col_obj.Name = "col_obj";
            this.col_obj.ReadOnly = true;
            this.col_obj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_date
            // 
            this.col_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_date.HeaderText = "Date Start";
            this.col_date.MinimumWidth = 8;
            this.col_date.Name = "col_date";
            this.col_date.ReadOnly = true;
            this.col_date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repair_id,
            this.col_name,
            this.col_business_name,
            this.col_device,
            this.col_obj,
            this.col_date});
            this.dataGridView1.Location = new System.Drawing.Point(60, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1298, 410);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 805);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_uri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_repairs__archive);
            this.Controls.Add(this.button_customers_list);
            this.Controls.Add(this.button_new_customer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindows";
            this.Text = "Manager Riparazioni";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_new_customer;
        private System.Windows.Forms.Button button_customers_list;
        private System.Windows.Forms.Button button_repairs__archive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel label_uri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn repair_id;
        private DataGridViewTextBoxColumn col_name;
        private DataGridViewTextBoxColumn col_business_name;
        private DataGridViewTextBoxColumn col_device;
        private DataGridViewTextBoxColumn col_obj;
        private DataGridViewTextBoxColumn col_date;
    }
}