using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Durak
{
    public partial class Settings : Form
    {
        
        private readonly List<Image> backImages = new List<Image>();

        
        private readonly List<Image> tableImages = new List<Image>();
        private static int indexOfBack = 0;
        private static int indexOfTable = 0;
        public Settings()
        {
            InitializeComponent();
            var path = Path.Combine(@"..\..\Resources\");
            
            //create list of images that name starts with  "back"
            var count = Directory.GetFiles(path + @"Cards\", "back*").Length;
            for (var i = 0; i < count; i++)
                backImages.Add(Image.FromFile(Path.Combine(path + @"Cards\", "back" + (i + 1) + ".jpg")));
            
            //create list of images that name starts with "table"
            count = Directory.GetFiles(path, "table*").Length;
            for (var i = 0; i < count; i++) 
                tableImages.Add(Image.FromFile(Path.Combine(path, "table" + i + ".jpg")));
            
            picBoxSuit.Image = backImages[indexOfBack];
            picBoxTable.Image = tableImages[indexOfTable];
        }
        /// <summary>
        ///   Changes the background table by click left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnTableLeft_Click(object sender, EventArgs e)
        {
            if (picBoxTable.Image != null)
            {
                var index = tableImages.IndexOf(picBoxTable.Image);
                if (index > 0)
                {
                    index--;
                    picBoxTable.Image = tableImages[index];
                }
                indexOfTable = index;
            }
        }
        /// <summary>
        /// Changes the background image by click left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuitLeft_Click(object sender, EventArgs e)
        {
            if (picBoxSuit.Image != null)
            {
                var index = backImages.IndexOf(picBoxSuit.Image);
                if (index > 0)
                {
                    index--;
                    picBoxSuit.Image = backImages[index];
                }
                indexOfBack = index;
            }
        }
        /// <summary>
        /// Changes the background image by click right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuitRight_Click(object sender, EventArgs e)
        {
            if (picBoxSuit.Image != null)
            {
                var index = backImages.IndexOf(picBoxSuit.Image);
                if (index < backImages.Count - 1)
                {
                    index++;
                    picBoxSuit.Image = backImages[index];
                }
                indexOfBack = index;
            }
        }
        /// <summary>
        /// Changes the background table by click right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTableRight_Click(object sender, EventArgs e)
        {
            if (picBoxTable.Image != null)
            {
                var index = tableImages.IndexOf(picBoxTable.Image);
                if (index < tableImages.Count - 1)
                {
                    index++;
                    picBoxTable.Image = tableImages[index];
                }
                indexOfTable = index;
            }
        }

        private void btnSettingsClose_Click(object sender, EventArgs e)
        {
            logIn.backImage = picBoxSuit.Image;
            logIn.tableImage = picBoxTable.Image;
            Close();
        }
    }
}