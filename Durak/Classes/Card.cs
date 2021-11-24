namespace Durak.Classes
{
    public class Card
    {
        public enum SUIT
        {
            HEARTS,
            DIAMONDS,
            SPADES,
            CLUBS
        }

        public enum VALUE
        {
            SIX = 6,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK,
            QUEEN,
            KING,
            ACE
        }

        public SUIT Csuit { get; set; }
        public VALUE Cvalue { get; set; }
        public bool InHand { get; set; }

        public string GetName()
        {
            return Csuit.ToString().Substring(0, 1).ToLower() + ((int) Cvalue);
        }

        public override string ToString()
        {
            return Cvalue + " of " + Csuit.ToString().Substring(0, 1).ToUpper();
        }
    }
}