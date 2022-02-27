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

        //The function that shows statistics and points of the game
        private void ShowStats()
        {
            
            int countgames = logIn.computerPoints + logIn.playerPoints +  logIn.drawPoints; // if 0, will be exception divide on 0 
            lblplayername.Text = logIn.NickName;
            lblCdraw.Text =  logIn.drawPoints.ToString();
            lblClost.Text = logIn.playerPoints.ToString();
            lblCwin.Text = logIn.computerPoints.ToString();
            lblPdraw.Text =  logIn.drawPoints.ToString();
            lblPwin.Text = logIn.playerPoints.ToString();
            lblPlost.Text = logIn.computerPoints.ToString();
            if (countgames > 0)
            {
                lblCprWin.Text =(100 * logIn.computerPoints/countgames) +"%"; //here
                lblCprLost.Text = (100 * logIn.playerPoints / countgames) + "%"; //here
                lblPprLost.Text = (100 * logIn.computerPoints / countgames) + "%"; //here
                lblPprWin.Text =(100* logIn.playerPoints/countgames) + "%"; //here
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            logIn.drawPoints =0;
            logIn.playerPoints = 0;
            logIn.computerPoints = 0;
            ShowStats();
            this.Refresh();
        
        }
    }
}