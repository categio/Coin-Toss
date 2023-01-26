using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coin_Toss
{
    class Coin
    {
        //field to represent the the side facing up; 
        private string sideUp;

        //RNG
        Random rand = new Random();

        //Constructor
        public Coin()
        {
            sideUp = "Heads";
        }

        //the toss method simulates the coin toss
        public void Toss()
        {
            //use random number ot determine the sid eof the coin that is facing up.
            //0=Heads, 1=Tails

            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }

        //The GetSideUp method returns the value of the sideUp field.

        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
