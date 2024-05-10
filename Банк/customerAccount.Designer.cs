namespace Банк
{
    partial class CustomerAccount
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
            this.timerDeposit = new System.Windows.Forms.Timer(this.components);
            this.lblFIO = new System.Windows.Forms.Label();
            this.btnCloseCredit = new System.Windows.Forms.Button();
            this.btnOpenCredit = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnPersonalData = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.flpnCredit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDisplayCredit = new System.Windows.Forms.Button();
            this.pnHome = new System.Windows.Forms.Panel();
            this.flpnMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.flpnPersonalData = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDisplayPersonalData = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.flwAccounts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnDisplayAccount = new System.Windows.Forms.Button();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.flpnDeposit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnDisplayDeposit = new System.Windows.Forms.Button();
            this.btnOpenDeposit = new System.Windows.Forms.Button();
            this.btnCloseDeposit = new System.Windows.Forms.Button();
            this.timerCredit = new System.Windows.Forms.Timer(this.components);
            this.timerPersonalData = new System.Windows.Forms.Timer(this.components);
            this.timerAccounts = new System.Windows.Forms.Timer(this.components);
            this.flpnCredit.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.flpnMenu.SuspendLayout();
            this.flpnPersonalData.SuspendLayout();
            this.flwAccounts.SuspendLayout();
            this.flpnDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerDeposit
            // 
            this.timerDeposit.Interval = 10;
            this.timerDeposit.Tick += new System.EventHandler(this.timerDeposit_Tick);
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblFIO.Location = new System.Drawing.Point(28, 23);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(478, 47);
            this.lblFIO.TabIndex = 2;
            this.lblFIO.Text = "Иванов Иван Иванович";
            // 
            // btnCloseCredit
            // 
            this.btnCloseCredit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCloseCredit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCloseCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCredit.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnCloseCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseCredit.Location = new System.Drawing.Point(0, 146);
            this.btnCloseCredit.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseCredit.Name = "btnCloseCredit";
            this.btnCloseCredit.Size = new System.Drawing.Size(472, 73);
            this.btnCloseCredit.TabIndex = 4;
            this.btnCloseCredit.Text = " Закрыть кредит";
            this.btnCloseCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseCredit.UseVisualStyleBackColor = false;
            // 
            // btnOpenCredit
            // 
            this.btnOpenCredit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOpenCredit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCredit.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnOpenCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCredit.Location = new System.Drawing.Point(0, 73);
            this.btnOpenCredit.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenCredit.Name = "btnOpenCredit";
            this.btnOpenCredit.Size = new System.Drawing.Size(472, 73);
            this.btnOpenCredit.TabIndex = 3;
            this.btnOpenCredit.Text = " Открыть кредит";
            this.btnOpenCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCredit.UseVisualStyleBackColor = false;
            // 
            // btnCredit
            // 
            this.btnCredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCredit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCredit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredit.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredit.Location = new System.Drawing.Point(0, 0);
            this.btnCredit.Margin = new System.Windows.Forms.Padding(0);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(398, 73);
            this.btnCredit.TabIndex = 2;
            this.btnCredit.Text = " Кредиты";
            this.btnCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredit.UseVisualStyleBackColor = false;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnPersonalData
            // 
            this.btnPersonalData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersonalData.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPersonalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalData.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPersonalData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnPersonalData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalData.Location = new System.Drawing.Point(0, 0);
            this.btnPersonalData.Margin = new System.Windows.Forms.Padding(0);
            this.btnPersonalData.Name = "btnPersonalData";
            this.btnPersonalData.Size = new System.Drawing.Size(398, 73);
            this.btnPersonalData.TabIndex = 2;
            this.btnPersonalData.Text = " Персональные данные";
            this.btnPersonalData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalData.UseVisualStyleBackColor = false;
            this.btnPersonalData.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Location = new System.Drawing.Point(512, 85);
            this.pnMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(745, 625);
            this.pnMain.TabIndex = 36;
            // 
            // flpnCredit
            // 
            this.flpnCredit.Controls.Add(this.btnCredit);
            this.flpnCredit.Controls.Add(this.btnDisplayCredit);
            this.flpnCredit.Controls.Add(this.btnOpenCredit);
            this.flpnCredit.Controls.Add(this.btnCloseCredit);
            this.flpnCredit.Location = new System.Drawing.Point(0, 219);
            this.flpnCredit.Margin = new System.Windows.Forms.Padding(0);
            this.flpnCredit.MaximumSize = new System.Drawing.Size(472, 217);
            this.flpnCredit.MinimumSize = new System.Drawing.Size(472, 73);
            this.flpnCredit.Name = "flpnCredit";
            this.flpnCredit.Size = new System.Drawing.Size(472, 73);
            this.flpnCredit.TabIndex = 0;
            // 
            // btnDisplayCredit
            // 
            this.btnDisplayCredit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDisplayCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayCredit.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDisplayCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDisplayCredit.Location = new System.Drawing.Point(398, 0);
            this.btnDisplayCredit.Margin = new System.Windows.Forms.Padding(0);
            this.btnDisplayCredit.Name = "btnDisplayCredit";
            this.btnDisplayCredit.Size = new System.Drawing.Size(74, 73);
            this.btnDisplayCredit.TabIndex = 5;
            this.btnDisplayCredit.Text = "▼";
            this.btnDisplayCredit.UseVisualStyleBackColor = true;
            this.btnDisplayCredit.Click += new System.EventHandler(this.btnDisplayCredit_Click);
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnHome.Controls.Add(this.flpnMenu);
            this.pnHome.Controls.Add(this.pnMain);
            this.pnHome.Controls.Add(this.lblFIO);
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(0, 0);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(1300, 750);
            this.pnHome.TabIndex = 7;
            // 
            // flpnMenu
            // 
            this.flpnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpnMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpnMenu.Controls.Add(this.flpnPersonalData);
            this.flpnMenu.Controls.Add(this.flwAccounts);
            this.flpnMenu.Controls.Add(this.flpnDeposit);
            this.flpnMenu.Controls.Add(this.flpnCredit);
            this.flpnMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnMenu.Location = new System.Drawing.Point(34, 85);
            this.flpnMenu.Name = "flpnMenu";
            this.flpnMenu.Size = new System.Drawing.Size(472, 625);
            this.flpnMenu.TabIndex = 3;
            // 
            // flpnPersonalData
            // 
            this.flpnPersonalData.Controls.Add(this.btnPersonalData);
            this.flpnPersonalData.Controls.Add(this.btnDisplayPersonalData);
            this.flpnPersonalData.Controls.Add(this.btnUpdateData);
            this.flpnPersonalData.Location = new System.Drawing.Point(0, 0);
            this.flpnPersonalData.Margin = new System.Windows.Forms.Padding(0);
            this.flpnPersonalData.MaximumSize = new System.Drawing.Size(472, 146);
            this.flpnPersonalData.MinimumSize = new System.Drawing.Size(472, 73);
            this.flpnPersonalData.Name = "flpnPersonalData";
            this.flpnPersonalData.Size = new System.Drawing.Size(472, 73);
            this.flpnPersonalData.TabIndex = 2;
            // 
            // btnDisplayPersonalData
            // 
            this.btnDisplayPersonalData.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDisplayPersonalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayPersonalData.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDisplayPersonalData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDisplayPersonalData.Location = new System.Drawing.Point(398, 0);
            this.btnDisplayPersonalData.Margin = new System.Windows.Forms.Padding(0);
            this.btnDisplayPersonalData.Name = "btnDisplayPersonalData";
            this.btnDisplayPersonalData.Size = new System.Drawing.Size(74, 73);
            this.btnDisplayPersonalData.TabIndex = 4;
            this.btnDisplayPersonalData.Text = "▼";
            this.btnDisplayPersonalData.UseVisualStyleBackColor = true;
            this.btnDisplayPersonalData.Click += new System.EventHandler(this.btnDisplayPersonalData_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateData.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateData.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnUpdateData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateData.Location = new System.Drawing.Point(0, 73);
            this.btnUpdateData.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(472, 73);
            this.btnUpdateData.TabIndex = 3;
            this.btnUpdateData.Text = "Обновить данные";
            this.btnUpdateData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateData.UseVisualStyleBackColor = false;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // flwAccounts
            // 
            this.flwAccounts.Controls.Add(this.btnAccounts);
            this.flwAccounts.Controls.Add(this.btnDisplayAccount);
            this.flwAccounts.Controls.Add(this.btnOpenAccount);
            this.flwAccounts.Location = new System.Drawing.Point(0, 73);
            this.flwAccounts.Margin = new System.Windows.Forms.Padding(0);
            this.flwAccounts.MaximumSize = new System.Drawing.Size(472, 146);
            this.flwAccounts.MinimumSize = new System.Drawing.Size(472, 73);
            this.flwAccounts.Name = "flwAccounts";
            this.flwAccounts.Size = new System.Drawing.Size(472, 73);
            this.flwAccounts.TabIndex = 5;
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccounts.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.Location = new System.Drawing.Point(0, 0);
            this.btnAccounts.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(398, 73);
            this.btnAccounts.TabIndex = 2;
            this.btnAccounts.Text = "Счета";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnDisplayAccount
            // 
            this.btnDisplayAccount.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDisplayAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAccount.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDisplayAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDisplayAccount.Location = new System.Drawing.Point(398, 0);
            this.btnDisplayAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnDisplayAccount.Name = "btnDisplayAccount";
            this.btnDisplayAccount.Size = new System.Drawing.Size(74, 73);
            this.btnDisplayAccount.TabIndex = 3;
            this.btnDisplayAccount.Text = "▼";
            this.btnDisplayAccount.UseVisualStyleBackColor = true;
            this.btnDisplayAccount.Click += new System.EventHandler(this.btnDisplayAccount_Click);
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOpenAccount.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAccount.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnOpenAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAccount.Location = new System.Drawing.Point(0, 73);
            this.btnOpenAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(472, 73);
            this.btnOpenAccount.TabIndex = 3;
            this.btnOpenAccount.Text = " Открыть счёт";
            this.btnOpenAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAccount.UseVisualStyleBackColor = false;
            // 
            // flpnDeposit
            // 
            this.flpnDeposit.Controls.Add(this.btnDeposit);
            this.flpnDeposit.Controls.Add(this.btnDisplayDeposit);
            this.flpnDeposit.Controls.Add(this.btnOpenDeposit);
            this.flpnDeposit.Controls.Add(this.btnCloseDeposit);
            this.flpnDeposit.Location = new System.Drawing.Point(0, 146);
            this.flpnDeposit.Margin = new System.Windows.Forms.Padding(0);
            this.flpnDeposit.MaximumSize = new System.Drawing.Size(472, 217);
            this.flpnDeposit.MinimumSize = new System.Drawing.Size(472, 73);
            this.flpnDeposit.Name = "flpnDeposit";
            this.flpnDeposit.Size = new System.Drawing.Size(472, 73);
            this.flpnDeposit.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(0, 0);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(398, 73);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = " Вклады";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnDisplayDeposit
            // 
            this.btnDisplayDeposit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDisplayDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayDeposit.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDisplayDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDisplayDeposit.Location = new System.Drawing.Point(398, 0);
            this.btnDisplayDeposit.Margin = new System.Windows.Forms.Padding(0);
            this.btnDisplayDeposit.Name = "btnDisplayDeposit";
            this.btnDisplayDeposit.Size = new System.Drawing.Size(74, 73);
            this.btnDisplayDeposit.TabIndex = 3;
            this.btnDisplayDeposit.Text = "▼";
            this.btnDisplayDeposit.UseVisualStyleBackColor = true;
            this.btnDisplayDeposit.Click += new System.EventHandler(this.btnDisplayDeposit_Click);
            // 
            // btnOpenDeposit
            // 
            this.btnOpenDeposit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOpenDeposit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDeposit.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnOpenDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDeposit.Location = new System.Drawing.Point(0, 73);
            this.btnOpenDeposit.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenDeposit.Name = "btnOpenDeposit";
            this.btnOpenDeposit.Size = new System.Drawing.Size(472, 73);
            this.btnOpenDeposit.TabIndex = 3;
            this.btnOpenDeposit.Text = " Открыть вклад";
            this.btnOpenDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDeposit.UseVisualStyleBackColor = false;
            // 
            // btnCloseDeposit
            // 
            this.btnCloseDeposit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCloseDeposit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCloseDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDeposit.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnCloseDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseDeposit.Location = new System.Drawing.Point(0, 146);
            this.btnCloseDeposit.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseDeposit.Name = "btnCloseDeposit";
            this.btnCloseDeposit.Size = new System.Drawing.Size(472, 73);
            this.btnCloseDeposit.TabIndex = 4;
            this.btnCloseDeposit.Text = " Закрыть вклад";
            this.btnCloseDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseDeposit.UseVisualStyleBackColor = false;
            // 
            // timerCredit
            // 
            this.timerCredit.Interval = 10;
            this.timerCredit.Tick += new System.EventHandler(this.timerCredit_Tick);
            // 
            // timerPersonalData
            // 
            this.timerPersonalData.Interval = 10;
            this.timerPersonalData.Tick += new System.EventHandler(this.timerPersonalData_Tick);
            // 
            // timerAccounts
            // 
            this.timerAccounts.Interval = 10;
            this.timerAccounts.Tick += new System.EventHandler(this.timerAccounts_Tick);
            // 
            // CustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.pnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerAccount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomerAccount_Load);
            this.flpnCredit.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            this.pnHome.PerformLayout();
            this.flpnMenu.ResumeLayout(false);
            this.flpnPersonalData.ResumeLayout(false);
            this.flwAccounts.ResumeLayout(false);
            this.flpnDeposit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerDeposit;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Button btnCloseCredit;
        private System.Windows.Forms.Button btnOpenCredit;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnPersonalData;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.FlowLayoutPanel flpnCredit;
        private System.Windows.Forms.FlowLayoutPanel flpnDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnOpenDeposit;
        private System.Windows.Forms.Button btnCloseDeposit;
        private System.Windows.Forms.FlowLayoutPanel flpnMenu;
        private System.Windows.Forms.Timer timerCredit;
        private System.Windows.Forms.FlowLayoutPanel flpnPersonalData;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Button btnDisplayDeposit;
        private System.Windows.Forms.Button btnDisplayCredit;
        private System.Windows.Forms.Button btnDisplayPersonalData;
        private System.Windows.Forms.Timer timerPersonalData;
        private System.Windows.Forms.FlowLayoutPanel flwAccounts;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnDisplayAccount;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Timer timerAccounts;
    }
}