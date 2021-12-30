using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.Classes
{
    class Score
    {
        public static int drawPoint { get; set; }
        public static int playerPoint { get; set; }
        public static int computerPoint { get; set; }

        Score(){
            drawPoint = 0;

            playerPoint = 0;

            computerPoint = 0;
        }
    }

}