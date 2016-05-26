using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    using Models;

    public class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch":
                    AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3], int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4]), inputArgs[5]);
                    break;
                case "ListTeams":
                    ListTeams();
                    break;
                case "ListMatches":
                    ListMatches();
                    break;
            }
        }


        private static void AddTeam(string name, string nickname, DateTime foundationDate)
        {
            var team = new Team(name, nickname, foundationDate);
            if (League.Teams.Any(t => t.Name == team.Name))
            {
                throw new InvalidOperationException("The team has already added to the league.");
            }
            League.Teams.Add(team);
        }


        private static void AddMatch(int id, string homeTeam, string awayTeam, int homeGoals, int awayGoals)
        {
            if (!League.Teams.Any(t => t.Name == homeTeam))
            {
                throw new InvalidOperationException("Such team doesn't exists in the league.");
            }

            if (!League.Teams.Any(t => t.Name == awayTeam))
            {
                throw new InvalidOperationException("Such team doesn't exists in the league.");
            }

            var score = new Score(homeGoals, awayGoals);
            var teamHome = League.Teams.FirstOrDefault(t => t.Name == homeTeam);
            var teamAway = League.Teams.FirstOrDefault(t => t.Name == awayTeam);
            var match = new Match(teamHome, teamAway, score, id);
            if (League.Matches.Any(t => t.Id == match.Id))
            {
                throw new InvalidOperationException("The match has already added to the league.");
            }

            League.Matches.Add(match);
        }


        private static void AddPlayerToTeam(string fname, string lname, DateTime birth, decimal salary, string teamName)
        {
            if (!League.Teams.Any(t => t.Name == teamName))
            {
                throw new InvalidOperationException("Such team doesn't exists in the league.");
            }
            var team = League.Teams.FirstOrDefault(t => t.Name == teamName);
            var player = new Player(fname, lname, salary, birth, team);
            if (team.Players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName))
            {
                throw new InvalidOperationException("Such player already exist in the team.");
            }
            team.Players.Add(player);
        }


        private static void ListTeams()
        {
            foreach (var team in League.Teams)
            {
                Console.WriteLine(team);
            }
        }

        private static void ListMatches()
        {
            foreach (var match in League.Matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
