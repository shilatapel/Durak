using System;
using System.IO;
using System.Text;
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
           
        //The function check if player enter nickname and pick image profile to sign in
        private void btnSignIn_Click(object sender, EventArgs e)
        {
          
           
            if (txtName.Text != string.Empty && (radioBtnFemale.Checked || radioBtnMale.Checked))
            {
                DialogResult = DialogResult.OK;
                logIn.NickName = txtName.Text;
                logIn.imgProfile = radioBtnFemale.Checked ? "female" : "male";

                ReadScoresFile();
                Visible = false;
                var M = new Menu();
                M.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid Nick Name or profile picture Please try Again", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void ReadScoresFile()
        {
            var filename = logIn.NickName + "Score.txt";
            try
            {
                if (!File.Exists(filename))
                {
                    try
                    {
                        using (var stream = File.Open(filename, FileMode.Create))
                        {
                            using (var bw = new BinaryWriter(stream, Encoding.UTF8, false))
                            {
                                //bw.Write(today.ToString("yyyy-M-dd--HH-mm-ss"));
                                bw.Write(0);
                                bw.Write(0);
                                bw.Write(0);

                            }
                        }
                    }
                    catch (IOException error)
                    {
                        MessageBox.Show(error.Message + @"\n Cannot create file.");
                    }
                }

                using (var stream = File.Open(filename, FileMode.Open))
                {
                    using (var br = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        logIn.drawPoints = br.ReadInt32();
                        logIn.playerPoints = br.ReadInt32();
                        logIn.computerPoints = br.ReadInt32();
                    }
                }
            }
            catch (IOException error)
            {
                MessageBox.Show(error.Message + @"\n Cannot open file.");
            }
        }

    }
}