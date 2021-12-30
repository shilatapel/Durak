using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.Classes
{
    //class for score game
    class Score
    {
        public static int drawPoint { get; set; }   //draw point
        public static int playerPoint { get; set; }  //player win point
        public static int computerPoint { get; set; }   //computer win point


        //constructor initializ to Zero
        Score() { 
            drawPoint = 0;

            playerPoint = 0;

            computerPoint = 0;
        }
    }

}