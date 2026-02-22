using IPB2.WinFormsApp.Database.AppDbContextModels;

namespace IPB2.WinFormsApp
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //string name = txtName.Text;
            //MessageBox.Show($"Hello Poe La Min - {name}.");

            AppDbContext db = new AppDbContext();
            TblAccount item = new TblAccount()
            {
                AccountId = Guid.NewGuid().ToString(),
                Balance = Convert.ToDecimal(txtBalance.Text),
                IsDelete = false,
                MobileNo = txtMobileNo.Text,
                Name = txtName.Text,
                Password = txtPassword.Text,
            };
            db.TblAccounts.Add(item);
            int result = db.SaveChanges();
            MessageBox.Show(result > 0 ? "Saving Successful." : "Saving Failed");

            ClearControls();
        }
        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ClearControls()
        {
            txtBalance.Clear();
            txtMobileNo.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
