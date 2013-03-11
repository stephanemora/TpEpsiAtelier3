using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatchClub
{
    public class Club
    {
        private String Name;

        public Club(String name)
        {
            Name = name;
        }

        public override string ToString()
        {
           return Name;
        }
    }

}
