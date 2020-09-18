namespace Manager_riparazioni
{
    partial class CustomerList
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
            this.button_new_repair = new System.Windows.Forms.Button();
            this.button_edit_row = new System.Windows.Forms.Button();
            this.button_delete_row = new System.Windows.Forms.Button();
            this.col_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_business_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_creation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_new_customer
            // 
            this.button_new_customer.Location = new System.Drawing.Point(53, 545);
            this.button_new_customer.Name = "button_new_customer";
            this.button_new_customer.Size = new System.Drawing.Size(203, 72);
            this.button_new_customer.TabIndex = 1;
            this.button_new_customer.Text = "Aggiungi Cliente";
            this.button_new_customer.UseVisualStyleBackColor = true;
            this.button_new_customer.Click += new System.EventHandler(this.New_Customer_Click);
            // 
            // button_new_repair
            // 
            this.button_new_repair.Location = new System.Drawing.Point(810, 545);
            this.button_new_repair.Name = "button_new_repair";
            this.button_new_repair.Size = new System.Drawing.Size(204, 72);
            this.button_new_repair.TabIndex = 1;
            this.button_new_repair.Text = "Nuova Riparazione";
            this.button_new_repair.UseVisualStyleBackColor = true;
            this.button_new_repair.Click += new System.EventHandler(this.New_Repair_Click);
            // 
            // button_edit_row
            // 
            this.button_edit_row.Location = new System.Drawing.Point(383, 545);
            this.button_edit_row.Name = "button_edit_row";
            this.button_edit_row.Size = new System.Drawing.Size(150, 72);
            this.button_edit_row.TabIndex = 1;
            this.button_edit_row.Text = "Modifica";
            this.button_edit_row.UseVisualStyleBackColor = true;
            this.button_edit_row.Click += new System.EventHandler(this.button_edit_row_Click);
            // 
            // button_delete_row
            // 
            this.button_delete_row.Location = new System.Drawing.Point(572, 545);
            this.button_delete_row.Name = "button_delete_row";
            this.button_delete_row.Size = new System.Drawing.Size(127, 72);
            this.button_delete_row.TabIndex = 1;
            this.button_delete_row.Text = "Elimina";
            this.button_delete_row.UseVisualStyleBackColor = true;
            this.button_delete_row.Click += new System.EventHandler(this.button_delete_row_Click);
            // 
            // col_index
            // 
            this.col_index.HeaderText = "Index";
            this.col_index.MinimumWidth = 8;
            this.col_index.Name = "col_index";
            this.col_index.ReadOnly = true;
            this.col_index.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_index.Visible = false;
            this.col_index.Width = 150;
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
            // col_surname
            // 
            this.col_surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_surname.HeaderText = "Surname";
            this.col_surname.MinimumWidth = 8;
            this.col_surname.Name = "col_surname";
            this.col_surname.ReadOnly = true;
            this.col_surname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_type
            // 
            this.col_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_type.HeaderText = "Type";
            this.col_type.MinimumWidth = 8;
            this.col_type.Name = "col_type";
            this.col_type.ReadOnly = true;
            this.col_type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // col_creation_date
            // 
            this.col_creation_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_creation_date.HeaderText = "Creation Date";
            this.col_creation_date.MinimumWidth = 8;
            this.col_creation_date.Name = "col_creation_date";
            this.col_creation_date.ReadOnly = true;
            this.col_creation_date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_index,
            this.col_name,
            this.col_surname,
            this.col_type,
            this.col_business_name,
            this.col_creation_date});
            this.dataGridView1.Location = new System.Drawing.Point(49, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(965, 434);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_DoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.RowsSelectionChanged);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_delete_row);
            this.Controls.Add(this.button_edit_row);
            this.Controls.Add(this.button_new_repair);
            this.Controls.Add(this.button_new_customer);
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomersListClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_new_customer;
        private System.Windows.Forms.Button button_new_repair;
        private System.Windows.Forms.Button button_edit_row;
        private System.Windows.Forms.Button button_delete_row;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_business_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_creation_date;
    }
}