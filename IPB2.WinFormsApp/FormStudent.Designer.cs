namespace IPB2.WinFormsApp
{
    partial class frmStudent
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
            lblStudent = new Label();
            txtStudentName = new TextBox();
            txtAge = new TextBox();
            lblAge = new Label();
            txtClassNo = new TextBox();
            lblClassNo = new Label();
            txtMobileNo = new TextBox();
            lblMobileNo = new Label();
            txtParentName = new TextBox();
            lblParentName = new Label();
            txtFees = new TextBox();
            lblFees = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(54, 34);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(120, 25);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "StudentName";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(54, 75);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(230, 31);
            txtStudentName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(358, 75);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(230, 31);
            txtAge.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(358, 34);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 25);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age";
            // 
            // txtClassNo
            // 
            txtClassNo.Location = new Point(54, 190);
            txtClassNo.Name = "txtClassNo";
            txtClassNo.Size = new Size(230, 31);
            txtClassNo.TabIndex = 5;
            // 
            // lblClassNo
            // 
            lblClassNo.AutoSize = true;
            lblClassNo.Location = new Point(54, 149);
            lblClassNo.Name = "lblClassNo";
            lblClassNo.Size = new Size(76, 25);
            lblClassNo.TabIndex = 4;
            lblClassNo.Text = "ClassNo";
            // 
            // txtMobileNo
            // 
            txtMobileNo.Location = new Point(358, 190);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.Size = new Size(230, 31);
            txtMobileNo.TabIndex = 7;
            // 
            // lblMobileNo
            // 
            lblMobileNo.AutoSize = true;
            lblMobileNo.Location = new Point(358, 149);
            lblMobileNo.Name = "lblMobileNo";
            lblMobileNo.Size = new Size(91, 25);
            lblMobileNo.TabIndex = 6;
            lblMobileNo.Text = "MobileNo";
            // 
            // txtParentName
            // 
            txtParentName.Location = new Point(54, 295);
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(230, 31);
            txtParentName.TabIndex = 9;
            // 
            // lblParentName
            // 
            lblParentName.AutoSize = true;
            lblParentName.Location = new Point(54, 254);
            lblParentName.Name = "lblParentName";
            lblParentName.Size = new Size(108, 25);
            lblParentName.TabIndex = 8;
            lblParentName.Text = "ParentName";
            // 
            // txtFees
            // 
            txtFees.Location = new Point(358, 295);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(230, 31);
            txtFees.TabIndex = 11;
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(358, 254);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(47, 25);
            lblFees.TabIndex = 10;
            lblFees.Text = "Fees";
            lblFees.Click += label6_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(172, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(358, 362);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFees);
            Controls.Add(lblFees);
            Controls.Add(txtParentName);
            Controls.Add(lblParentName);
            Controls.Add(txtMobileNo);
            Controls.Add(lblMobileNo);
            Controls.Add(txtClassNo);
            Controls.Add(lblClassNo);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtStudentName);
            Controls.Add(lblStudent);
            Name = "frmStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudent;
        private TextBox txtStudentName;
        private TextBox txtAge;
        private Label lblAge;
        private TextBox txtClassNo;
        private Label lblClassNo;
        private TextBox txtMobileNo;
        private Label lblMobileNo;
        private TextBox txtParentName;
        private Label lblParentName;
        private TextBox txtFees;
        private Label lblFees;
        private Button btnSave;
        private Button btnCancel;
    }
}