using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatchClub
{
    public class Match
    {
        private Club home;
        private Club away;
        private int homeGoals;
        private int awayGoals;
        private bool isHomeForfeit;
        private bool isAwayForfeit;

        public Match(Club home, Club away, bool isHomeForfeit, bool isAwayForfeit)
        {
            this.home = home;
            this.away = away;
            this.isHomeForfeit = isHomeForfeit;
            this.isAwayForfeit = isAwayForfeit;
        }

        public Match(Club home, Club away, int hgoals, int agoals)
        {
            this.home = home;
            this.away = away;
            this.homeGoals = hgoals;
            this.awayGoals = agoals;
        }

        public Club Away
        {
            get
            {
                return this.Away;
            }
        }

        public int AwayGoals
        {
            get
            {
                return this.awayGoals;
            }
        }

        public Club Home
        {
            get
            {
                return this.home;
            }
        }

        public int HomeGoals
        {
            get
            {
                return this.homeGoals;
            }
        }

        public bool IsAwayForfeit
        {
            get
            {
                return this.isAwayForfeit;
            }
        }

        public bool IsDraw
        {
            get
            {
                if ((homeGoals - awayGoals) == 0)
                    return true;
                return false;
            }
        }

        public bool IsHomeForfeit
        {
            get
            {
                return this.isHomeForfeit;
            }
        }

    }

    


}
