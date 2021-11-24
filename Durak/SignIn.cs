using System;
using System.Windows.Forms;

namespace Durak
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            // this.AcceptButton = btnSignIn;

            var W = new Welcome();

            if (W.ShowDialog(this) == DialogResult.OK)
            {
                //W.Close();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && (radioBtnFemale.Checked || radioBtnMale.Checked))
            {
                DialogResult = DialogResult.OK;
                logIn.NickName = txtName.Text;
                if (radioBtnFemale.Checked)
                    logIn.imgProfile = "female";
                else
                    logIn.imgProfile = "male";

                Visible = false;
                var M = new Menu();
                M.Show();
            }
            else
            {
                MessageBox.Show("Invalid Nick Name or profile picture Please try Again", "ERROR", MessageBoxButtons.OK);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "DURAK APP", MessageBoxButtons.YesNo) ==
                DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}