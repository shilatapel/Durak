using System;
using System.Windows.Forms;
using Durak.Classes;

namespace Durak
{
    public partial class ScoreAndStatistics : Form
    {
        public ScoreAndStatistics()
        {


            InitializeComponent();
            
            ShowStats();
        }

        private void ShowStats()
        {

     

            int countgames = Score.computerPoint + Score.playerPoint + Score.drawPoint + 1; // if 0, will be exception divide on 0 
            lblplayername.Text = logIn.NickName;
            lblCdraw.Text = Score.drawPoint.ToString();
            lblClost.Text = Score.playerPoint.ToString();
            lblCwin.Text = Score.computerPoint.ToString();
            lblPdraw.Text = Score.drawPoint.ToString();
            lblPwin.Text = Score.playerPoint.ToString();
            lblPlost.Text = Score.computerPoint.ToString();
            lblCprWin.Text =(100*Score.computerPoint/countgames) +"%"; //here
            lblCprLost.Text = (100 * Score.playerPoint / countgames) + "%"; //here
            lblPprLost.Text = (100 * Score.computerPoint / countgames) + "%"; //here
            lblPprWin.Text =(100* Score.playerPoint/countgames) + "%"; //here




        }

        private void btnOK_Click(object sender, EventArgs e)
        {   
            
            this.Hide();
           
        }
    }
}