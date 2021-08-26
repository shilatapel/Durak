using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.AcceptButton = btnSignIn;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty&& (radioBtnFemale.Checked||radioBtnMale.Checked) )
            {
                this.DialogResult = DialogResult.OK;
                logIn.NickName = txtName.Text;
                if (radioBtnFemale.Checked)
                    logIn.imgProfile = "female";
                else
                    logIn.imgProfile = "male";
            }
            else
                MessageBox.Show("Invalid Nick Name or profile picture Please try Again");
        }
    }
}
