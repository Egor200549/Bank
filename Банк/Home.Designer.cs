namespace Банк
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnHome = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblShowStatistic = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFindCustomer = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.pnHome.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnHome.Controls.Add(this.panel8);
            this.pnHome.Controls.Add(this.lblCurrentTime);
            this.pnHome.Controls.Add(this.panel7);
            this.pnHome.Controls.Add(this.panel6);
            this.pnHome.Controls.Add(this.panel5);
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(0, 0);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(1300, 750);
            this.pnHome.TabIndex = 4;
            this.pnHome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHome_Paint);
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.pictureBox8);
            this.panel8.Controls.Add(this.groupBox5);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(663, 387);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(480, 100);
            this.panel8.TabIndex = 7;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(387, 14);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(70, 70);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(38, 70);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 1);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Что-то";
            this.label4.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblCurrentTime.Location = new System.Drawing.Point(476, 95);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(348, 95);
            this.lblCurrentTime.TabIndex = 6;
            this.lblCurrentTime.Text = "00:00:00";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.groupBox4);
            this.panel7.Controls.Add(this.lblShowStatistic);
            this.panel7.Location = new System.Drawing.Point(157, 387);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(480, 100);
            this.panel7.TabIndex = 5;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(387, 14);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(70, 70);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(38, 70);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 1);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // lblShowStatistic
            // 
            this.lblShowStatistic.AutoSize = true;
            this.lblShowStatistic.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShowStatistic.ForeColor = System.Drawing.Color.White;
            this.lblShowStatistic.Location = new System.Drawing.Point(32, 26);
            this.lblShowStatistic.Name = "lblShowStatistic";
            this.lblShowStatistic.Size = new System.Drawing.Size(297, 33);
            this.lblShowStatistic.TabIndex = 0;
            this.lblShowStatistic.Text = "Смотреть статистику";
            this.lblShowStatistic.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.lblShowStatistic.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Controls.Add(this.lblFindCustomer);
            this.panel6.Location = new System.Drawing.Point(663, 264);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(480, 100);
            this.panel6.TabIndex = 3;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(387, 13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(38, 70);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 1);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lblFindCustomer
            // 
            this.lblFindCustomer.AutoSize = true;
            this.lblFindCustomer.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFindCustomer.ForeColor = System.Drawing.Color.White;
            this.lblFindCustomer.Location = new System.Drawing.Point(32, 26);
            this.lblFindCustomer.Name = "lblFindCustomer";
            this.lblFindCustomer.Size = new System.Drawing.Size(222, 33);
            this.lblFindCustomer.TabIndex = 0;
            this.lblFindCustomer.Text = "Найти клиента";
            this.lblFindCustomer.Click += new System.EventHandler(this.lblFindCustomer_Click);
            this.lblFindCustomer.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.lblFindCustomer.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.lblAddCustomer);
            this.panel5.Location = new System.Drawing.Point(157, 264);
            this.panel5.MaximumSize = new System.Drawing.Size(480, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 100);
            this.panel5.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(387, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(38, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 1);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddCustomer.ForeColor = System.Drawing.Color.White;
            this.lblAddCustomer.Location = new System.Drawing.Point(32, 26);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(262, 33);
            this.lblAddCustomer.TabIndex = 0;
            this.lblAddCustomer.Text = "Добавить клиента";
            this.lblAddCustomer.Click += new System.EventHandler(this.lblAddCustomer_Click);
            this.lblAddCustomer.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.lblAddCustomer.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // currentTime
            // 
            this.currentTime.Interval = 1;
            this.currentTime.Tick += new System.EventHandler(this.currentTime_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.pnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnHome.ResumeLayout(false);
            this.pnHome.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblShowStatistic;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFindCustomer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Timer currentTime;
    }
}