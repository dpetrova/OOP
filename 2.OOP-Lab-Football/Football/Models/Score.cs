using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score() : this(0, 0)
        {
        }

        public Score(int homeGoals, int awayGoals)
        {
            this.HomeTeamGoals = homeGoals;
            this.AwayTeamGoals = awayGoals;
        }

        public int AwayTeamGoals
        {
            get { return this.awayTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Goals value cannot be negative.");
                }
                this.awayTeamGoals = value;
            }
        }

        [Range(0, 100, ErrorMessage = "Goals value cannot be negative")]
        public int HomeTeamGoals
        {
            get { return this.homeTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Goals value cannot be negative.");
                }
                this.homeTeamGoals = value;
            }
        }
    }
}
