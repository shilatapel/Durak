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
        }

        private void button1_Click(object sender, EventArgs e)
        {

     

            int countgames = Score.computerPoint + Score.playerPoint + Score.drawPoint; 
            lblplayername.Text = logIn.NickName;
            lblCdraw.Text = Score.drawPoint.ToString();
            lblClost.Text = Score.playerPoint.ToString();
            lblCwin.Text = Score.computerPoint.ToString();
            lblPdraw.Text = Score.drawPoint.ToString();
            lblPwin.Text = Score.playerPoint.ToString();
            lblPlost.Text = Score.computerPoint.ToString();
            lblCprWin.Text =(100*Score.computerPoint/countgames) +"%";
            lblCprLost.Text = (100 * Score.playerPoint / countgames) + "%";
            lblPprLost.Text = (100 * Score.computerPoint / countgames) + "%";
            lblPprWin.Text =(100* Score.playerPoint/countgames) + "%";




        }

        private void btnOK_Click(object sender, EventArgs e)
        {   
            
            this.Hide();
           
        }
    }
}