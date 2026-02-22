namespace IPB2.WinFormsApp
{
    partial class frmAccount
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            btnCancle = new Button();
            lblName = new Label();
            txtName = new TextBox();
            txtMobileNo = new TextBox();
            lblMobileNo = new Label();
            txtBalance = new TextBox();
            lblBalance = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(162, 403);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(307, 403);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(112, 34);
            btnCancle.TabIndex = 1;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(104, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 3;
            // 
            // txtMobileNo
            // 
            txtMobileNo.Location = new Point(104, 146);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.Size = new Size(150, 31);
            txtMobileNo.TabIndex = 5;
            // 
            // lblMobileNo
            // 
            lblMobileNo.AutoSize = true;
            lblMobileNo.Location = new Point(104, 118);
            lblMobileNo.Name = "lblMobileNo";
            lblMobileNo.Size = new Size(91, 25);
            lblMobileNo.TabIndex = 4;
            lblMobileNo.Text = "MobileNo";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(104, 222);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(150, 31);
            txtBalance.TabIndex = 7;
            txtBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(104, 194);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(71, 25);
            lblBalance.TabIndex = 6;
            lblBalance.Text = "Balance";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(104, 294);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(104, 266);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 467);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Controls.Add(txtMobileNo);
            Controls.Add(lblMobileNo);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Name = "frmAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancle;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtMobileNo;
        private Label lblMobileNo;
        private TextBox txtBalance;
        private Label lblBalance;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}
