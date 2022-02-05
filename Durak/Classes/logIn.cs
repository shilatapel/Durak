using System.Drawing;

namespace Durak
{


    // class log in 
    internal class logIn
    {
        public static string NickName { get; set; } = "Nick";
        public static string imgProfile { get; set; }
        public static Image backImage { get; set; } = Properties.Resources.back1;
        public static Image tableImage  { get; set; } = Properties.Resources.table0;
        public static int drawPoints {get;set;} 
        public static int playerPoints {get;set;} 
        public static int computerPoints {get;set;}

}
}