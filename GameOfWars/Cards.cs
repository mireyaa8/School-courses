using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfWars
{
    public class Cards
    {
        public CardFace Face { get; set; }
        public CardSuit Suite { get; set; }
        public override string ToString()
        {
            int face = (int)Enum.Parse(typeof(CardFace), this.Face.ToString());
            char suit = (char)this.Suite;
            if (face > 10)
            {
                char charFace = this.Face.ToString()[0];
                return $"{charFace}{suit}";

            }
            
            return $"{Face}{suit}";



        }
    }
}
