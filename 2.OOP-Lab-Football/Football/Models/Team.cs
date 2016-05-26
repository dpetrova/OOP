using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Data;

    public class Team
    {
        private string name;
        private string nickname;
        private DateTime foundationDate;
        private ICollection<Player> players;

        public Team(string name, string nickname, DateTime foundationDate)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.FoundationDate = foundationDate;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("The name length should be at least 5 characters.");
                }
                this.name = value;
            }
        }


        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("The nickname length should be at least 5 characters.");
                }
                this.nickname = value;
            }
        }

        public DateTime FoundationDate
        {
            get { return this.foundationDate; }
            set { this.foundationDate = value; }
        }

        public ICollection<Player> Players
        {
            get { return this.players; }
        }

        //public void AddPlayer(Player player)
        //{
        //    if (this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName))
        //    {
        //        throw new InvalidOperationException("This player has already added to the team.");
        //    }
        //    this.Players.Add(player);
        //}

        //public void RemovePlayer(Player player)
        //{
        //    if (!this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName))
        //    {
        //        throw new InvalidOperationException("Such player doesn't exist in the team.");
        //    }
        //    this.Players.Remove(player);
        //}

        public override string ToString()
        {
            return string.Format("Team details: name: {0} / nickname: {1} / date of foundation: {2}",
                                                            this.Name, this.Nickname, this.FoundationDate.Year);
        }

    }
}
