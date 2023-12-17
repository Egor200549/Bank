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
            System.Windows.Forms.Label lblStatus;
            System.Windows.Forms.Label lblAddress;
            System.Windows.Forms.Label lblAddCustomer;
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnHome = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cmbSocialStatus = new System.Windows.Forms.ComboBox();
            this.socialstatusesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet1 = new Банк.bankDataSet1();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.mTxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.mTxtPassport = new System.Windows.Forms.MaskedTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mTxtDateBirth = new System.Windows.Forms.MaskedTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.socialstatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socialstatusesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.social_statusesTableAdapter = new Банк.bankDataSet1TableAdapters.social_statusesTableAdapter();
            lblStatus = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblAddCustomer = new System.Windows.Forms.Label();
            this.pnHome.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            lblStatus.Location = new System.Drawing.Point(674, 425);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(198, 23);
            lblStatus.TabIndex = 32;
            lblStatus.Text = "Социальный статус";
            // 
            // lblAddress
            // 
            lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            lblAddress.Location = new System.Drawing.Point(674, 113);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(65, 23);
            lblAddress.TabIndex = 26;
            lblAddress.Text = "Адрес";
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
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblEmail.Location = new System.Drawing.Point(674, 321);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(147, 23);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Почта (e-mail)";
            // 
            // lblTelephone
            // 
            this.lblTelephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblTelephone.Location = new System.Drawing.Point(674, 217);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(93, 23);
            this.lblTelephone.TabIndex = 28;
            this.lblTelephone.Text = "Телефон";
            // 
            // lblPassport
            // 
            this.lblPassport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblPassport.Location = new System.Drawing.Point(39, 529);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(90, 23);
            this.lblPassport.TabIndex = 24;
            this.lblPassport.Text = "Паспорт";
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblDateBirth.Location = new System.Drawing.Point(39, 425);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(159, 23);
            this.lblDateBirth.TabIndex = 15;
            this.lblDateBirth.Text = "Дата рождения";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblMiddleName.Location = new System.Drawing.Point(39, 321);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(97, 23);
            this.lblMiddleName.TabIndex = 13;
            this.lblMiddleName.Text = "Отчество";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblLastName.Location = new System.Drawing.Point(39, 217);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Фамилия";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblName.Location = new System.Drawing.Point(39, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 23);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Имя";
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnHome.Controls.Add(this.btnSignIn);
            this.pnHome.Controls.Add(lblStatus);
            this.pnHome.Controls.Add(this.panel11);
            this.pnHome.Controls.Add(this.lblEmail);
            this.pnHome.Controls.Add(this.panel12);
            this.pnHome.Controls.Add(this.lblTelephone);
            this.pnHome.Controls.Add(this.panel13);
            this.pnHome.Controls.Add(lblAddress);
            this.pnHome.Controls.Add(this.panel14);
            this.pnHome.Controls.Add(this.lblPassport);
            this.pnHome.Controls.Add(this.panel9);
            this.pnHome.Controls.Add(this.lblDateBirth);
            this.pnHome.Controls.Add(this.panel7);
            this.pnHome.Controls.Add(this.lblMiddleName);
            this.pnHome.Controls.Add(this.panel8);
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
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(670, 565);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Padding = new System.Windows.Forms.Padding(5);
            this.btnSignIn.Size = new System.Drawing.Size(587, 55);
            this.btnSignIn.TabIndex = 33;
            this.btnSignIn.Text = "Добавить";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.cmbSocialStatus);
            this.panel11.Location = new System.Drawing.Point(671, 461);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(586, 55);
            this.panel11.TabIndex = 31;
            // 
            // cmbSocialStatus
            // 
            this.cmbSocialStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSocialStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.socialstatusesBindingSource2, "id_social_status", true));
            this.cmbSocialStatus.DataSource = this.socialstatusesBindingSource2;
            this.cmbSocialStatus.DisplayMember = "name_socal_status";
            this.cmbSocialStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSocialStatus.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSocialStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.cmbSocialStatus.FormattingEnabled = true;
            this.cmbSocialStatus.Location = new System.Drawing.Point(12, 11);
            this.cmbSocialStatus.Name = "cmbSocialStatus";
            this.cmbSocialStatus.Size = new System.Drawing.Size(558, 31);
            this.cmbSocialStatus.TabIndex = 33;
            this.cmbSocialStatus.ValueMember = "id_social_status";
            this.cmbSocialStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSocialStatus_KeyPress);
            // 
            // socialstatusesBindingSource2
            // 
            this.socialstatusesBindingSource2.DataMember = "social_statuses";
            this.socialstatusesBindingSource2.DataSource = this.bankDataSet1BindingSource;
            // 
            // bankDataSet1BindingSource
            // 
            this.bankDataSet1BindingSource.DataSource = this.bankDataSet1;
            this.bankDataSet1BindingSource.Position = 0;
            // 
            // bankDataSet1
            // 
            this.bankDataSet1.DataSetName = "bankDataSet1";
            this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.txtEmail);
            this.panel12.Location = new System.Drawing.Point(671, 357);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(586, 55);
            this.panel12.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.mTxtTelephone);
            this.panel13.Location = new System.Drawing.Point(671, 253);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(586, 55);
            this.panel13.TabIndex = 27;
            // 
            // mTxtTelephone
            // 
            this.mTxtTelephone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mTxtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtTelephone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTxtTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.mTxtTelephone.Location = new System.Drawing.Point(12, 14);
            this.mTxtTelephone.Margin = new System.Windows.Forms.Padding(0);
            this.mTxtTelephone.Mask = "+7 (000) 000-00-00";
            this.mTxtTelephone.Name = "mTxtTelephone";
            this.mTxtTelephone.Size = new System.Drawing.Size(397, 25);
            this.mTxtTelephone.TabIndex = 35;
            this.mTxtTelephone.ValidatingType = typeof(System.DateTime);
            this.mTxtTelephone.Click += new System.EventHandler(this.mTxtTelephone_Click);
            this.mTxtTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtTelephone_Validating);
            // 
            // panel14
            // 
            this.panel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.txtAddress);
            this.panel14.Location = new System.Drawing.Point(671, 149);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(586, 55);
            this.panel14.TabIndex = 25;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtAddress.Location = new System.Drawing.Point(12, 14);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(558, 25);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.mTxtPassport);
            this.panel9.Location = new System.Drawing.Point(36, 565);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(586, 55);
            this.panel9.TabIndex = 23;
            // 
            // mTxtPassport
            // 
            this.mTxtPassport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mTxtPassport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtPassport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTxtPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.mTxtPassport.Location = new System.Drawing.Point(12, 14);
            this.mTxtPassport.Margin = new System.Windows.Forms.Padding(0);
            this.mTxtPassport.Mask = "00 00 000000";
            this.mTxtPassport.Name = "mTxtPassport";
            this.mTxtPassport.Size = new System.Drawing.Size(397, 25);
            this.mTxtPassport.TabIndex = 34;
            this.mTxtPassport.ValidatingType = typeof(System.DateTime);
            this.mTxtPassport.Click += new System.EventHandler(this.maskedText_Click);
            this.mTxtPassport.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtPassport_Validating);
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.mTxtDateBirth);
            this.panel7.Location = new System.Drawing.Point(36, 461);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(586, 55);
            this.panel7.TabIndex = 14;
            // 
            // mTxtDateBirth
            // 
            this.mTxtDateBirth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mTxtDateBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTxtDateBirth.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTxtDateBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.mTxtDateBirth.Location = new System.Drawing.Point(12, 14);
            this.mTxtDateBirth.Margin = new System.Windows.Forms.Padding(0);
            this.mTxtDateBirth.Mask = "0000/00/00";
            this.mTxtDateBirth.Name = "mTxtDateBirth";
            this.mTxtDateBirth.Size = new System.Drawing.Size(397, 25);
            this.mTxtDateBirth.TabIndex = 33;
            this.mTxtDateBirth.ValidatingType = typeof(System.DateTime);
            this.mTxtDateBirth.Click += new System.EventHandler(this.maskedText_Click);
            this.mTxtDateBirth.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtDateBirth_Validating);
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.txtMiddleName);
            this.panel8.Location = new System.Drawing.Point(36, 357);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(586, 55);
            this.panel8.TabIndex = 12;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.txtMiddleName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.txtMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            this.txtMiddleName.Validating += new System.ComponentModel.CancelEventHandler(this.txtMiddleName_Validating);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtLastName);
            this.panel6.Location = new System.Drawing.Point(36, 253);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(586, 55);
            this.panel6.TabIndex = 10;
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
            this.txtLastName.Size = new System.Drawing.Size(558, 25);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Location = new System.Drawing.Point(36, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(586, 55);
            this.panel5.TabIndex = 8;
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
            this.txtName.Size = new System.Drawing.Size(558, 25);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.groupBox2.Location = new System.Drawing.Point(34, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1223, 1);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // socialstatusesBindingSource
            // 
            this.socialstatusesBindingSource.DataMember = "social_statuses";
            this.socialstatusesBindingSource.DataSource = this.bankDataSet1;
            // 
            // socialstatusesBindingSource1
            // 
            this.socialstatusesBindingSource1.DataMember = "social_statuses";
            this.socialstatusesBindingSource1.DataSource = this.bankDataSet1BindingSource;
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
            this.pnHome.ResumeLayout(false);
            this.pnHome.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.MaskedTextBox mTxtDateBirth;
        private System.Windows.Forms.MaskedTextBox mTxtPassport;
        private System.Windows.Forms.MaskedTextBox mTxtTelephone;
        private System.Windows.Forms.ComboBox cmbSocialStatus;
        private System.Windows.Forms.Button btnSignIn;
        private bankDataSet1 bankDataSet1;
        private System.Windows.Forms.BindingSource socialstatusesBindingSource;
        private bankDataSet1TableAdapters.social_statusesTableAdapter social_statusesTableAdapter;
        private System.Windows.Forms.BindingSource socialstatusesBindingSource1;
        private System.Windows.Forms.BindingSource bankDataSet1BindingSource;
        private System.Windows.Forms.BindingSource socialstatusesBindingSource2;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
    }
}