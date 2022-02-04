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
            //TODO Move in visual designer player's column. not enough wide if result 100% in any textboxes
            ShowStats();
        }

        //The function that shows statistics and points of the game
        private void ShowStats()
        {
            Score.SetValues();
            int countgames = Score.computerPoint + Score.playerPoint + Score.drawPoint; // if 0, will be exception divide on 0 
            lblplayername.Text = logIn.NickName;
            lblCdraw.Text = Score.drawPoint.ToString();
            lblClost.Text = Score.playerPoint.ToString();
            lblCwin.Text = Score.computerPoint.ToString();
            lblPdraw.Text = Score.drawPoint.ToString();
            lblPwin.Text = Score.playerPoint.ToString();
            lblPlost.Text = Score.computerPoint.ToString();
            if (countgames > 0)
            {
                lblCprWin.Text =(100*Score.computerPoint/countgames) +"%"; //here
                lblCprLost.Text = (100 * Score.playerPoint / countgames) + "%"; //here
                lblPprLost.Text = (100 * Score.computerPoint / countgames) + "%"; //here
                lblPprWin.Text =(100* Score.playerPoint/countgames) + "%"; //here
            }
            else
            {
                lblCprWin.Text = "0%";
                lblCprLost.Text = "0%";
                lblPprLost.Text = "0%";
                lblPprWin.Text = "0%";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {   
            
            this.Close();
           
        }
    }
}