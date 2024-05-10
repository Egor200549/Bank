namespace Банк
{
    partial class TransferToAccount
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
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Panel panel3;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.lblGoBack = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblNameAccountFrom = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            panel1.Controls.Add(this.lblGoBack);
            panel1.Controls.Add(this.lblName);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(745, 73);
            panel1.TabIndex = 0;
            // 
            // lblGoBack
            // 
            this.lblGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoBack.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGoBack.ForeColor = System.Drawing.Color.White;
            this.lblGoBack.Location = new System.Drawing.Point(604, 22);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(112, 28);
            this.lblGoBack.TabIndex = 6;
            this.lblGoBack.Text = "← назад";
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            this.lblGoBack.MouseEnter += new System.EventHandler(this.lblGoBack_MouseEnter);
            this.lblGoBack.MouseLeave += new System.EventHandler(this.lblGoBack_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 16, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(361, 33);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Перевод между счетами";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 73);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(745, 544);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(20, 215);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 23);
            label4.TabIndex = 4;
            label4.Text = "Куда";
            // 
            // panel3
            // 
            panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel3.BackColor = System.Drawing.Color.White;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(this.lblNum);
            panel3.Controls.Add(this.flowLayoutPanel1);
            panel3.Controls.Add(this.lblNameAccountFrom);
            panel3.Location = new System.Drawing.Point(20, 112);
            panel3.Margin = new System.Windows.Forms.Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(705, 90);
            panel3.TabIndex = 3;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(16, 50);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(355, 23);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "-- 0000 - Неснижаемый остаток 0,01\r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblSum);
            this.flowLayoutPanel1.Controls.Add(this.lblPercentage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(584, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 48, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(119, 88);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // lblSum
            // 
            this.lblSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.Location = new System.Drawing.Point(0, 15);
            this.lblSum.Margin = new System.Windows.Forms.Padding(0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lblSum.Size = new System.Drawing.Size(71, 35);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "100.00";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercentage.Location = new System.Drawing.Point(24, 50);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(44, 23);
            this.lblPercentage.TabIndex = 1;
            this.lblPercentage.Text = "1 %";
            // 
            // lblNameAccountFrom
            // 
            this.lblNameAccountFrom.AutoSize = true;
            this.lblNameAccountFrom.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameAccountFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNameAccountFrom.Location = new System.Drawing.Point(15, 15);
            this.lblNameAccountFrom.Name = "lblNameAccountFrom";
            this.lblNameAccountFrom.Size = new System.Drawing.Size(161, 23);
            this.lblNameAccountFrom.TabIndex = 3;
            this.lblNameAccountFrom.Text = "Название счета";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(20, 76);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 23);
            label3.TabIndex = 1;
            label3.Text = "Откуда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(20, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(245, 33);
            label2.TabIndex = 0;
            label2.Text = "Детали перевода";
            // 
            // TransferToAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(745, 809);
            this.Controls.Add(panel2);
            this.Controls.Add(panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferToAccount";
            this.Load += new System.EventHandler(this.TransferToAccount_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblNameAccountFrom;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGoBack;
    }
}