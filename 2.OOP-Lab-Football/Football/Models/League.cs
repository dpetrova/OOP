using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Models
{
    public static class League
    {
        private static ICollection<Match> matches = new List<Match>();
        private static ICollection<Team> teams = new List<Team>();

        public static ICollection<Match> Matches
        {
            get { return matches; }
        }

        public static ICollection<Team> Teams
        {
            get { return teams; }
        }

        //public static void AddTeam(Team team)
        //{
        //    if (teams.Any(t => t.Name == team.Name))
        //    {
        //        throw new InvalidOperationException("The team has already added.");
        //    }
        //    teams.Add(team);
        //}

        //public static void RemoveTeam(Team team)
        //{
        //    if (!teams.Any(t => t.Name == team.Name))
        //    {
        //        throw new InvalidOperationException("The team does not exist in the league.");
        //    }
        //    teams.Remove(team);
        //}

        //public static void AddMatch(Match match)
        //{
        //    if (matches.Any(m => m.Id == match.Id))
        //    {
        //        throw new InvalidOperationException("The match has already added.");
        //    }
        //    matches.Add(match);
        //}
    }
}
