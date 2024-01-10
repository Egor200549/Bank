namespace Банк
{
    partial class FormAddCustomer
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
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Panel panel17;
            System.Windows.Forms.Panel panel21;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtPassportPlace = new System.Windows.Forms.TextBox();
            this.lblPassportPlace = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.mTxtPassport = new System.Windows.Forms.MaskedTextBox();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.mTxtDateBirth = new System.Windows.Forms.MaskedTextBox();
            this.lblPassport = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.mTxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.mTxtPassportDate = new System.Windows.Forms.MaskedTextBox();
            this.lblPassportDate = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.socialstatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet1 = new Банк.bankDataSet1();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnHome = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.social_statusesTableAdapter = new Банк.bankDataSet1TableAdapters.social_statusesTableAdapter();
            lblAddCustomer = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel17 = new System.Windows.Forms.Panel();
            panel21 = new System.Windows.Forms.Panel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            this.panel23.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.pnHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddCustomer
            // 
            lblAddCustomer.AutoSize = true;
            lblAddCustomer.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            lblAddCustomer.Location = new System.Drawing.Point(28, 23);
            lblAddCustomer.Name = "lblAddCustomer";
            lblAddCustomer.Size = new System.Drawing.Size(371, 47);
            lblAddCustomer.TabIndex = 2;
            lblAddCustomer.Text = "Добавить клиента";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel17);
            flowLayoutPanel1.Controls.Add(panel21);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new System.Drawing.Point(31, 110);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1247, 599);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(this.panel5);
            panel2.Controls.Add(this.lblName);
            panel2.Controls.Add(this.lblMiddleName);
            panel2.Controls.Add(this.panel8);
            panel2.Controls.Add(this.panel6);
            panel2.Controls.Add(this.lblLastName);
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            panel2.Size = new System.Drawing.Size(589, 348);
            panel2.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(586, 55);
            this.panel5.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtName.Location = new System.Drawing.Point(12, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(558, 25);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 23);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Имя";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblMiddleName.Location = new System.Drawing.Point(3, 233);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(97, 23);
            this.lblMiddleName.TabIndex = 13;
            this.lblMiddleName.Text = "Отчество";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.txtMiddleName);
            this.panel8.Location = new System.Drawing.Point(0, 273);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(586, 55);
            this.panel8.TabIndex = 12;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddleName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddleName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtMiddleName.Location = new System.Drawing.Point(12, 14);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(0);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(558, 25);
            this.txtMiddleName.TabIndex = 1;
            this.txtMiddleName.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txtMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            this.txtMiddleName.Validating += new System.ComponentModel.CancelEventHandler(this.txtMiddleName_Validating);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtLastName);
            this.panel6.Location = new System.Drawing.Point(0, 158);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(586, 55);
            this.panel6.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtLastName.Location = new System.Drawing.Point(12, 14);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(558, 25);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblLastName.Location = new System.Drawing.Point(3, 118);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Фамилия";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(this.panel10);
            panel1.Controls.Add(this.lblPassportPlace);
            panel1.Controls.Add(this.panel15);
            panel1.Controls.Add(this.lblDateBirth);
            panel1.Controls.Add(this.panel16);
            panel1.Controls.Add(this.lblPassport);
            panel1.Location = new System.Drawing.Point(609, 0);
            panel1.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            panel1.Size = new System.Drawing.Size(589, 348);
            panel1.TabIndex = 42;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtPassportPlace);
            this.panel10.Location = new System.Drawing.Point(0, 273);
            this.panel10.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(586, 55);
            this.panel10.TabIndex = 27;
            // 
            // txtPassportPlace
            // 
            this.txtPassportPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassportPlace.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassportPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassportPlace.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassportPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtPassportPlace.Location = new System.Drawing.Point(12, 14);
            this.txtPassportPlace.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassportPlace.Multiline = true;
            this.txtPassportPlace.Name = "txtPassportPlace";
            this.txtPassportPlace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassportPlace.Size = new System.Drawing.Size(558, 25);
            this.txtPassportPlace.TabIndex = 1;
            this.txtPassportPlace.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txtPassportPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            this.txtPassportPlace.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassportPlace_Validating);
            // 
            // lblPassportPlace
            // 
            this.lblPassportPlace.AutoSize = true;
            this.lblPassportPlace.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassportPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblPassportPlace.Location = new System.Drawing.Point(3, 233);
            this.lblPassportPlace.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblPassportPlace.Name = "lblPassportPlace";
            this.lblPassportPlace.Size = new System.Drawing.Size(145, 23);
            this.lblPassportPlace.TabIndex = 28;
            this.lblPassportPlace.Text = "Место выдачи";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.mTxtPassport);
            this.panel15.Location = new System.Drawing.Point(0, 158);
            this.panel15.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(586, 55);
            this.panel15.TabIndex = 23;
            // 
            // mTxtPassport
            // 
            this.mTxtPassport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxtPassport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mTxtPassport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtPassport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTxtPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.mTxtPassport.Location = new System.Drawing.Point(12, 14);
            this.mTxtPassport.Margin = new System.Windows.Forms.Padding(0);
            this.mTxtPassport.Mask = "00 00 000000";
            this.mTxtPassport.Name = "mTxtPassport";
            this.mTxtPassport.Size = new System.Drawing.Size(558, 25);
            this.mTxtPassport.TabIndex = 34;
            this.mTxtPassport.ValidatingType = typeof(System.DateTime);
            this.mTxtPassport.Click += new System.EventHandler(this.maskedText_Click);
            this.mTxtPassport.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtPassport_Validating);
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblDateBirth.Location = new System.Drawing.Point(3, 3);
            this.lblDateBirth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(159, 23);
            this.lblDateBirth.TabIndex = 15;
            this.lblDateBirth.Text = "Дата рождения";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Transparent;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.mTxtDateBirth);
            this.panel16.Location = new System.Drawing.Point(0, 43);
            this.panel16.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(586, 55);
            this.panel16.TabIndex = 14;
            // 
            // mTxtDateBirth
            // 
            this.mTxtDateBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxtDateBirth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mTxtDateBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtDateBirth.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTxtDateBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.mTxtDateBirth.Location = new System.Drawing.Point(12, 14);
            this.mTxtDateBirth.Margin = new System.Windows.Forms.Padding(0);
            this.mTxtDateBirth.Mask = "0000/00/00";
            this.mTxtDateBirth.Name = "mTxtDateBirth";
            this.mTxtDateBirth.Size = new System.Drawing.Size(558, 25);
            this.mTxtDateBirth.TabIndex = 33;
            this.mTxtDateBirth.ValidatingType = typeof(System.DateTime);
            this.mTxtDateBirth.Click += new System.EventHandler(this.maskedText_Click);
            this.mTxtDateBirth.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtDateBirth_Validating_1);
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblPassport.Location = new System.Drawing.Point(3, 118);
            this.lblPassport.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(243, 23);
            this.lblPassport.TabIndex = 24;
            this.lblPassport.Text = "Серия и номер паспорта";
            // 
            // panel17
            // 
            panel17.AutoSize = true;
            panel17.Controls.Add(this.panel18);
            panel17.Controls.Add(this.panel19);
            panel17.Controls.Add(this.lblPassportDate);
            panel17.Controls.Add(this.lblTelephone);
            panel17.Controls.Add(this.panel20);
            panel17.Controls.Add(this.lblAddress);
            panel17.Location = new System.Drawing.Point(0, 348);
            panel17.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            panel17.Name = "panel17";
            panel17.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            panel17.Size = new System.Drawing.Size(589, 348);
            panel17.TabIndex = 43;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.mTxtTelephone);
            this.panel18.Location = new System.Drawing.Point(0, 273);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(586, 55);
            this.panel18.TabIndex = 27;
            // 
            // mTxtTelephone
            // 
            this.mTxtTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxtTelephone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mTxtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtTelephone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTxtTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.mTxtTelephone.Location = new System.Drawing.Point(12, 14);
            this.mTxtTelephone.Margin = new System.Windows.Forms.Padding(0);
            this.mTxtTelephone.Mask = "+7 (000) 000-00-00";
            this.mTxtTelephone.Name = "mTxtTelephone";
            this.mTxtTelephone.Size = new System.Drawing.Size(558, 25);
            this.mTxtTelephone.TabIndex = 35;
            this.mTxtTelephone.ValidatingType = typeof(System.DateTime);
            this.mTxtTelephone.Click += new System.EventHandler(this.maskedText_Click);
            this.mTxtTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtTelephone_Validating);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Transparent;
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Controls.Add(this.mTxtPassportDate);
            this.panel19.Location = new System.Drawing.Point(0, 43);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(586, 55);
            this.panel19.TabIndex = 29;
            // 
            // mTxtPassportDate
            // 
            this.mTxtPassportDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTxtPassportDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mTxtPassportDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtPassportDate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTxtPassportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.mTxtPassportDate.Location = new System.Drawing.Point(12, 14);
            this.mTxtPassportDate.Margin = new System.Windows.Forms.Padding(0);
            this.mTxtPassportDate.Mask = "0000/00/00";
            this.mTxtPassportDate.Name = "mTxtPassportDate";
            this.mTxtPassportDate.Size = new System.Drawing.Size(558, 25);
            this.mTxtPassportDate.TabIndex = 35;
            this.mTxtPassportDate.ValidatingType = typeof(System.DateTime);
            this.mTxtPassportDate.Click += new System.EventHandler(this.maskedText_Click);
            this.mTxtPassportDate.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtPassportDate_Validating);
            // 
            // lblPassportDate
            // 
            this.lblPassportDate.AutoSize = true;
            this.lblPassportDate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblPassportDate.Location = new System.Drawing.Point(3, 3);
            this.lblPassportDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblPassportDate.Name = "lblPassportDate";
            this.lblPassportDate.Size = new System.Drawing.Size(135, 23);
            this.lblPassportDate.TabIndex = 30;
            this.lblPassportDate.Text = "Дата выдачи";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblTelephone.Location = new System.Drawing.Point(3, 233);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(93, 23);
            this.lblTelephone.TabIndex = 28;
            this.lblTelephone.Text = "Телефон";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Transparent;
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel20.Controls.Add(this.txtAddress);
            this.panel20.Location = new System.Drawing.Point(0, 158);
            this.panel20.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(586, 55);
            this.panel20.TabIndex = 25;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtAddress.Location = new System.Drawing.Point(12, 14);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(558, 25);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblAddress.Location = new System.Drawing.Point(3, 118);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 23);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Адрес";
            // 
            // panel21
            // 
            panel21.AutoSize = true;
            panel21.Controls.Add(this.panel22);
            panel21.Controls.Add(this.lblStatus);
            panel21.Controls.Add(this.panel23);
            panel21.Controls.Add(this.lblEmail);
            panel21.Location = new System.Drawing.Point(609, 348);
            panel21.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            panel21.Name = "panel21";
            panel21.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            panel21.Size = new System.Drawing.Size(589, 233);
            panel21.TabIndex = 44;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Transparent;
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel22.Controls.Add(this.cmbStatus);
            this.panel22.Location = new System.Drawing.Point(0, 158);
            this.panel22.Margin = new System.Windows.Forms.Padding(0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(586, 55);
            this.panel22.TabIndex = 31;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.socialstatusesBindingSource, "id_social_status", true));
            this.cmbStatus.DataSource = this.socialstatusesBindingSource;
            this.cmbStatus.DisplayMember = "name_socal_status";
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(12, 11);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(558, 31);
            this.cmbStatus.TabIndex = 42;
            this.cmbStatus.ValueMember = "id_social_status";
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // socialstatusesBindingSource
            // 
            this.socialstatusesBindingSource.DataMember = "social_statuses";
            this.socialstatusesBindingSource.DataSource = this.bankDataSet1;
            // 
            // bankDataSet1
            // 
            this.bankDataSet1.DataSetName = "bankDataSet1";
            this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblStatus.Location = new System.Drawing.Point(3, 118);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(198, 23);
            this.lblStatus.TabIndex = 32;
            this.lblStatus.Text = "Социальный статус";
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.Transparent;
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Controls.Add(this.txtEmail);
            this.panel23.Location = new System.Drawing.Point(0, 43);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(586, 55);
            this.panel23.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtEmail.Location = new System.Drawing.Point(12, 14);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(558, 25);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblEmail.Location = new System.Drawing.Point(3, 3);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(147, 23);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Почта (e-mail)";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(this.pictBox);
            flowLayoutPanel2.Controls.Add(this.btnAddPhoto);
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 696);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 13);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(589, 305);
            flowLayoutPanel2.TabIndex = 41;
            // 
            // pictBox
            // 
            this.pictBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBox.Location = new System.Drawing.Point(0, 0);
            this.pictBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(248, 248);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox.TabIndex = 0;
            this.pictBox.TabStop = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddPhoto.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhoto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnAddPhoto.Location = new System.Drawing.Point(0, 248);
            this.btnAddPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddPhoto.Size = new System.Drawing.Size(250, 55);
            this.btnAddPhoto.TabIndex = 36;
            this.btnAddPhoto.Text = "Добавить фото";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1048, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(230, 55);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnHome
            // 
            this.pnHome.AutoScroll = true;
            this.pnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnHome.Controls.Add(flowLayoutPanel1);
            this.pnHome.Controls.Add(this.groupBox2);
            this.pnHome.Controls.Add(lblAddCustomer);
            this.pnHome.Controls.Add(this.btnAdd);
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(0, 0);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(1300, 750);
            this.pnHome.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.groupBox2.Location = new System.Drawing.Point(34, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1244, 1);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // social_statusesTableAdapter
            // 
            this.social_statusesTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.pnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddCustomer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddCustomer_FormClosed);
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            this.panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.pnHome.ResumeLayout(false);
            this.pnHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.Button btnAddPhoto;
        private bankDataSet1 bankDataSet1;
        private System.Windows.Forms.BindingSource socialstatusesBindingSource;
        private bankDataSet1TableAdapters.social_statusesTableAdapter social_statusesTableAdapter;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtPassportPlace;
        private System.Windows.Forms.Label lblPassportPlace;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.MaskedTextBox mTxtPassport;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.MaskedTextBox mTxtDateBirth;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.MaskedTextBox mTxtTelephone;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.MaskedTextBox mTxtPassportDate;
        private System.Windows.Forms.Label lblPassportDate;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
    }
}