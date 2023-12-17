namespace Банк
{
    partial class DataCustomer
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
            System.Windows.Forms.Label lblStatus;
            System.Windows.Forms.Label lblAddress;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdatePersonalData = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mTxtDateBirth = new System.Windows.Forms.MaskedTextBox();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.mTxtPassport = new System.Windows.Forms.MaskedTextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.mTxtTelephone = new System.Windows.Forms.MaskedTextBox();
            lblStatus = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            lblStatus.Location = new System.Drawing.Point(36, 546);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(198, 23);
            lblStatus.TabIndex = 32;
            lblStatus.Text = "Социальный статус";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            lblAddress.Location = new System.Drawing.Point(36, 232);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(65, 23);
            lblAddress.TabIndex = 26;
            lblAddress.Text = "Адрес";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnUpdatePersonalData);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.lblDateBirth);
            this.panel1.Controls.Add(lblStatus);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.lblPassport);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(lblAddress);
            this.panel1.Controls.Add(this.lblTelephone);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 756);
            this.panel1.TabIndex = 35;
            // 
            // btnUpdatePersonalData
            // 
            this.btnUpdatePersonalData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnUpdatePersonalData.FlatAppearance.BorderSize = 0;
            this.btnUpdatePersonalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePersonalData.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdatePersonalData.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePersonalData.Location = new System.Drawing.Point(33, 662);
            this.btnUpdatePersonalData.Name = "btnUpdatePersonalData";
            this.btnUpdatePersonalData.Padding = new System.Windows.Forms.Padding(5);
            this.btnUpdatePersonalData.Size = new System.Drawing.Size(431, 55);
            this.btnUpdatePersonalData.TabIndex = 34;
            this.btnUpdatePersonalData.Text = "Обновить данные";
            this.btnUpdatePersonalData.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.mTxtDateBirth);
            this.panel7.Location = new System.Drawing.Point(33, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(431, 55);
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
            this.mTxtDateBirth.ReadOnly = true;
            this.mTxtDateBirth.Size = new System.Drawing.Size(397, 25);
            this.mTxtDateBirth.TabIndex = 33;
            this.mTxtDateBirth.ValidatingType = typeof(System.DateTime);
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblDateBirth.Location = new System.Drawing.Point(36, 24);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(159, 23);
            this.lblDateBirth.TabIndex = 15;
            this.lblDateBirth.Text = "Дата рождения";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.mTxtPassport);
            this.panel9.Location = new System.Drawing.Point(33, 164);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(431, 55);
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
            this.mTxtPassport.ReadOnly = true;
            this.mTxtPassport.Size = new System.Drawing.Size(397, 25);
            this.mTxtPassport.TabIndex = 34;
            this.mTxtPassport.ValidatingType = typeof(System.DateTime);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.txtStatus);
            this.panel11.Location = new System.Drawing.Point(33, 580);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(431, 55);
            this.panel11.TabIndex = 31;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtStatus.Location = new System.Drawing.Point(12, 14);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(0);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(403, 25);
            this.txtStatus.TabIndex = 37;
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblPassport.Location = new System.Drawing.Point(36, 128);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(90, 23);
            this.lblPassport.TabIndex = 24;
            this.lblPassport.Text = "Паспорт";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblEmail.Location = new System.Drawing.Point(36, 440);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(147, 23);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Почта (e-mail)";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.txtAddress);
            this.panel14.Location = new System.Drawing.Point(33, 268);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(431, 55);
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
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(403, 25);
            this.txtAddress.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.txtEmail);
            this.panel12.Location = new System.Drawing.Point(33, 476);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(431, 55);
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
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(403, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblTelephone.Location = new System.Drawing.Point(36, 336);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(93, 23);
            this.lblTelephone.TabIndex = 28;
            this.lblTelephone.Text = "Телефон";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.mTxtTelephone);
            this.panel13.Location = new System.Drawing.Point(33, 372);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(431, 55);
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
            this.mTxtTelephone.ReadOnly = true;
            this.mTxtTelephone.Size = new System.Drawing.Size(397, 25);
            this.mTxtTelephone.TabIndex = 35;
            this.mTxtTelephone.ValidatingType = typeof(System.DateTime);
            // 
            // DataCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(720, 756);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataCustomer";
            this.Load += new System.EventHandler(this.DataCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.MaskedTextBox mTxtDateBirth;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.MaskedTextBox mTxtPassport;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.MaskedTextBox mTxtTelephone;
        private System.Windows.Forms.Button btnUpdatePersonalData;
    }
}