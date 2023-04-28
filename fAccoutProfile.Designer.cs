namespace QuanLyQuanCafe
{
    partial class fAccoutProfile
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
            panel2 = new Panel();
            txtUserName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbUserName = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbReEnterPass = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(13, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(628, 76);
            panel2.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(202, 16);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(413, 31);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(193, 29);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 77);
            panel1.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(203, 19);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(413, 31);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 21);
            label2.Name = "label2";
            label2.Size = new Size(157, 29);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbUserName);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(628, 87);
            panel3.TabIndex = 3;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(203, 21);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(413, 31);
            txbUserName.TabIndex = 1;
            txbUserName.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 23);
            label3.Name = "label3";
            label3.Size = new Size(125, 29);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbReEnterPass);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 270);
            panel4.Name = "panel4";
            panel4.Size = new Size(628, 87);
            panel4.TabIndex = 4;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(203, 21);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new Size(413, 31);
            txbReEnterPass.TabIndex = 1;
            txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(4, 23);
            label4.Name = "label4";
            label4.Size = new Size(177, 29);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(386, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(516, 363);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccoutProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(649, 400);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccoutProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAccoutProfile";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtUserName;
        private Label label1;
        private Panel panel1;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txbUserName;
        private Label label3;
        private Panel panel4;
        private TextBox txbReEnterPass;
        private Label label4;
        private Button btnUpdate;
        private Button btnExit;
    }
}