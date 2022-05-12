using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        public CompareByName (bool)
        {
            
        }

        public int Compare (Player p1, Player p2)
        {

            return String.Compare(p1.Name , p2.Name);
        }
        
    }

}