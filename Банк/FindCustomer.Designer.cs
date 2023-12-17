namespace Банк
{
    partial class FindCustomer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblAddCustomer;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnHome = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPassport = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.mTxtPassport = new System.Windows.Forms.MaskedTextBox();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mTxtDateBirth = new System.Windows.Forms.MaskedTextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bankDataSet1 = new Банк.bankDataSet1();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Банк.bankDataSet1TableAdapters.customersTableAdapter();
            lblAddCustomer = new System.Windows.Forms.Label();
            this.pnHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddCustomer
            // 
            lblAddCustomer.AutoSize = true;
            lblAddCustomer.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            lblAddCustomer.Location = new System.Drawing.Point(28, 24);
            lblAddCustomer.Name = "lblAddCustomer";
            lblAddCustomer.Size = new System.Drawing.Size(314, 47);
            lblAddCustomer.TabIndex = 34;
            lblAddCustomer.Text = "Найти клиента";
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnHome.Controls.Add(this.dataGridView1);
            this.pnHome.Controls.Add(this.lblPassport);
            this.pnHome.Controls.Add(this.panel9);
            this.pnHome.Controls.Add(this.lblDateBirth);
            this.pnHome.Controls.Add(this.panel7);
            this.pnHome.Controls.Add(this.lblLastName);
            this.pnHome.Controls.Add(this.panel6);
            this.pnHome.Controls.Add(this.lblName);
            this.pnHome.Controls.Add(this.panel5);
            this.pnHome.Controls.Add(this.groupBox2);
            this.pnHome.Controls.Add(lblAddCustomer);
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(0, 0);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(1300, 750);
            this.pnHome.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(34, 239);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1223, 382);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblPassport.Location = new System.Drawing.Point(979, 114);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(90, 23);
            this.lblPassport.TabIndex = 45;
            this.lblPassport.Text = "Паспорт";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.mTxtPassport);
            this.panel9.Location = new System.Drawing.Point(976, 150);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(281, 55);
            this.panel9.TabIndex = 44;
            // 
            // mTxtPassport
            // 
            this.mTxtPassport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxtPassport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mTxtPassport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtPassport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTxtPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.mTxtPassport.Location = new System.Drawing.Point(12, 14);
            this.mTxtPassport.Margin = new System.Windows.Forms.Padding(0);
            this.mTxtPassport.Mask = "00 00 000000";
            this.mTxtPassport.Name = "mTxtPassport";
            this.mTxtPassport.Size = new System.Drawing.Size(253, 25);
            this.mTxtPassport.TabIndex = 34;
            this.mTxtPassport.ValidatingType = typeof(System.DateTime);
            this.mTxtPassport.Click += new System.EventHandler(this.maskedText_Click);
            this.mTxtPassport.TextChanged += new System.EventHandler(this.mTxtPassport_TextChanged);
            this.mTxtPassport.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtPassport_Validating);
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblDateBirth.Location = new System.Drawing.Point(665, 114);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(159, 23);
            this.lblDateBirth.TabIndex = 43;
            this.lblDateBirth.Text = "Дата рождения";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.mTxtDateBirth);
            this.panel7.Location = new System.Drawing.Point(662, 150);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 55);
            this.panel7.TabIndex = 42;
            // 
            // mTxtDateBirth
            // 
            this.mTxtDateBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxtDateBirth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mTxtDateBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtDateBirth.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTxtDateBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.mTxtDateBirth.Location = new System.Drawing.Point(12, 14);
            this.mTxtDateBirth.Margin = new System.Windows.Forms.Padding(0);
            this.mTxtDateBirth.Mask = "0000/00/00";
            this.mTxtDateBirth.Name = "mTxtDateBirth";
            this.mTxtDateBirth.Size = new System.Drawing.Size(252, 25);
            this.mTxtDateBirth.TabIndex = 33;
            this.mTxtDateBirth.ValidatingType = typeof(System.DateTime);
            this.mTxtDateBirth.Click += new System.EventHandler(this.maskedText_Click);
            this.mTxtDateBirth.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtDateBirth_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblLastName.Location = new System.Drawing.Point(351, 114);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 39;
            this.lblLastName.Text = "Фамилия";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtLastName);
            this.panel6.Location = new System.Drawing.Point(348, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 55);
            this.panel6.TabIndex = 38;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtLastName.Location = new System.Drawing.Point(12, 14);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(252, 25);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblName.Location = new System.Drawing.Point(37, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 23);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Имя";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Location = new System.Drawing.Point(34, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 55);
            this.panel5.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtName.Location = new System.Drawing.Point(12, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 25);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.groupBox2.Location = new System.Drawing.Point(34, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1223, 1);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // bankDataSet1
            // 
            this.bankDataSet1.DataSetName = "bankDataSet1";
            this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.bankDataSet1;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // FindCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.pnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindCustomer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindCustomer_FormClosed);
            this.Load += new System.EventHandler(this.FindCustomer_Load);
            this.pnHome.ResumeLayout(false);
            this.pnHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.MaskedTextBox mTxtPassport;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.MaskedTextBox mTxtDateBirth;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private bankDataSet1 bankDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private bankDataSet1TableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}