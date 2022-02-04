using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Durak.Classes
{
    //class for score game
    public class Score
    {
        public static int drawPoint; //draw point
        public static int playerPoint; //player win point
        public static int computerPoint; //computer win point

        public static void SetValues()
        {
            var filename = logIn.NickName + "Score.txt";
            try
            {
                if (!File.Exists(filename)) 
                    CreateScoreFile(filename, drawPoint, playerPoint, computerPoint);
                
                using (var stream = File.Open(filename, FileMode.Open))
                {
                    using (var br = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        //TODO: mistake count. need to change. points are multiplied by 2 after each game 
                        drawPoint += br.ReadInt32();
                        playerPoint += br.ReadInt32();
                        computerPoint += br.ReadInt32();
                    }
                }
                
                CreateScoreFile(filename, drawPoint, playerPoint, computerPoint);
            }

            catch (IOException err)
            {
                MessageBox.Show(err.Message + @"\n Cannot open file.");
            }

            void CreateScoreFile(string filename, int dPoint, int pPoint, int cPoint)
            {
                try
                {
                    using (var stream = File.Open(filename, FileMode.Create))
                    {
                        using (var bw = new BinaryWriter(stream, Encoding.UTF8, false))
                        {
                            //bw.Write(today.ToString("yyyy-M-dd--HH-mm-ss"));
                            bw.Write(dPoint);
                            bw.Write(pPoint);
                            bw.Write(cPoint);

                        }
                    }
                }
                catch (IOException error)
                {
                    MessageBox.Show(error.Message + @"\n Cannot create file.");
                }
            }
        }
    }
}