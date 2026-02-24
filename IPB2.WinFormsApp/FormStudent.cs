using IPB2.WinFormsApp.Database.AppDbContextModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IPB2.WinFormsApp
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            TblStudent item = new TblStudent()
            {
                StudentId = Guid.NewGuid().ToString(),
                StudentName = txtStudentName.Text,
                Age = (int)Convert.ToInt64(txtAge.Text),
                ClassNo = txtClassNo.Text,
                MobileNo = txtMobileNo.Text,
                IsDeleted = false,
                ParentName = txtParentName.Text,
                Fees = (int)Convert.ToInt64(txtFees.Text),
            };
            db.TblStudents.Add(item);
            int result = db.SaveChanges();
            MessageBox.Show(result > 0 ? "Saving Successful." : "Saving Failed");

            ClearControls();
        }
        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ClearControls()
        {
            txtStudentName.Clear();
            txtAge.Clear();
            txtClassNo.Clear();
            txtMobileNo.Clear();
            txtParentName.Clear();
            txtFees.Clear();
            txtStudentName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}
