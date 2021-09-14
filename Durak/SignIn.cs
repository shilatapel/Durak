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
        bool flag = false;
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            // this.AcceptButton = btnSignIn;

            Welcome W = new Welcome();

            if (W.ShowDialog(this) == DialogResult.OK)
            {
                Menu M = new Menu();


            }
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
                MessageBox.Show("Invalid Nick Name or profile picture Please try Again","ERROR",MessageBoxButtons.OK);
        }
         protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "DURAK APP", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
