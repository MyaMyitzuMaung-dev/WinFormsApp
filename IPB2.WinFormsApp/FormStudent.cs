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
        private string _studentId = "";
        public frmStudent()
        {
            InitializeComponent();
        }
        //Read
        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (AppDbContext db = new AppDbContext())
            {
                dgvStudents.DataSource = db.TblStudents
                                           .Where(x => x.IsDeleted == false)
                                           .ToList();
            }

            // Hide unnecessary columns
            if (dgvStudents.Columns.Count > 0)
            {
                dgvStudents.Columns["StudentId"].Visible = false;
                dgvStudents.Columns["IsDeleted"].Visible = false;
            }
        }
        //Create
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please fill required fields.");
                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                TblStudent item = new TblStudent()
                {
                    StudentId = Guid.NewGuid().ToString(),
                    StudentName = txtStudentName.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    ClassNo = txtClassNo.Text,
                    MobileNo = txtMobileNo.Text,
                    ParentName = txtParentName.Text,
                    Fees = string.IsNullOrWhiteSpace(txtFees.Text)
                            ? 0
                            : Convert.ToInt32(txtFees.Text),
                    IsDeleted = false
                };

                db.TblStudents.Add(item);
                int result = db.SaveChanges();

                MessageBox.Show(result > 0
                    ? "Saving Successful."
                    : "Saving Failed.");
            }

            LoadData();
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                _studentId = row.Cells["StudentId"].Value.ToString();

                txtStudentName.Text = row.Cells["StudentName"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtClassNo.Text = row.Cells["ClassNo"].Value.ToString();
                txtMobileNo.Text = row.Cells["MobileNo"].Value.ToString();
                txtParentName.Text = row.Cells["ParentName"].Value.ToString();
                txtFees.Text = row.Cells["Fees"].Value.ToString();
            }
        }
        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_studentId))
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                var item = db.TblStudents
                             .FirstOrDefault(x => x.StudentId == _studentId);

                if (item != null)
                {
                    item.StudentName = txtStudentName.Text;
                    item.Age = Convert.ToInt32(txtAge.Text);
                    item.ClassNo = txtClassNo.Text;
                    item.MobileNo = txtMobileNo.Text;
                    item.ParentName = txtParentName.Text;
                    item.Fees = Convert.ToInt32(txtFees.Text);

                    db.SaveChanges();

                    MessageBox.Show("Update Successful.");
                }
            }

            LoadData();
            ClearControls();
            _studentId = "";
        }
        //Delete (Soft Delete)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_studentId))
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (AppDbContext db = new AppDbContext())
                {
                    var item = db.TblStudents
                                 .FirstOrDefault(x => x.StudentId == _studentId);

                    if (item != null)
                    {
                        item.IsDeleted = true;  
                        db.SaveChanges();

                        MessageBox.Show("Delete Successful.");
                    }
                }

                LoadData();
                ClearControls();
                _studentId = "";
            }
        }
    }
}
