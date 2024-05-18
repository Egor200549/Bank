namespace Банк
{
    partial class openAccount
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
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            lblName = new System.Windows.Forms.Label();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            flowLayoutPanel2.Controls.Add(lblName);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            flowLayoutPanel2.Size = new System.Drawing.Size(702, 73);
            flowLayoutPanel2.TabIndex = 22;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblName.ForeColor = System.Drawing.Color.White;
            lblName.Location = new System.Drawing.Point(20, 20);
            lblName.Margin = new System.Windows.Forms.Padding(0, 0, 16, 16);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(308, 33);
            lblName.TabIndex = 1;
            lblName.Text = "Открыть новый счёт";
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(702, 636);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.BackColor = System.Drawing.Color.Khaki;
            flowLayoutPanel3.Controls.Add(this.label3);
            flowLayoutPanel3.Controls.Add(this.label4);
            flowLayoutPanel3.Location = new System.Drawing.Point(20, 20);
            flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            flowLayoutPanel3.MaximumSize = new System.Drawing.Size(295, 0);
            flowLayoutPanel3.MinimumSize = new System.Drawing.Size(0, 295);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(20);
            flowLayoutPanel3.Size = new System.Drawing.Size(294, 295);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label3.MaximumSize = new System.Drawing.Size(310, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 84);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название вкладааааааааааааааааааа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.MaximumSize = new System.Drawing.Size(310, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 46);
            this.label4.TabIndex = 2;
            this.label4.Text = "Описание вкладааааааааааааааааа";
            // 
            // openAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(702, 709);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "openAccount";
            this.Load += new System.EventHandler(this.openAccount_Load);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}