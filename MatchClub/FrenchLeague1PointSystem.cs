using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatchClub
{
    public class FrenchLeague1PointSystem : PointSystem
    {
        private class PointTotal : Itotal
        {
            private int goalaverage;
            private int points;

            public PointTotal()
            {
                goalaverage = 0;
                points = 0;
            }

            public PointTotal(Match m, bool home)
            {
                points = m.HomeGoals + m.AwayGoals;
                if (home)
                    goalaverage = m.HomeGoals - m.AwayGoals;
                else
                    goalaverage = m.AwayGoals - m.HomeGoals;
            }

            public int CompareTo(object obj)
            {
                return -1;
            }

            public void Increment(ITotal with)
            {
                    
            }

            public override string ToString()
            {
                return null;
            }



        }

        private static FrenchLeague1PointSystem instance = null;
        private static readonly object mylock = new object();


        private FrenchLeague1PointSystem()
        {

        }

        public FrenchLeague1PointSystem ITotal
        {
            get
            {
                return this.ITotal;
            }
        }

        public static PointSystem Instance
        {
            get
            {
                lock ((mylock))
                {
                    if (instance == null)
                    {
                        instance = new PointSystem();
                    }

                    return instance;
                }
            }

        }

        public Itotal GetPointsFromMatch(Match m, bool isHome)
        {
            return new Itotal(m, isHome);
        }

    }
}
