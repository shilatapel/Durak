using System;
using System.Windows.Forms;

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
            var menu = (Menu) Application.OpenForms["Menu"];
            if (menu != null)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}