using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Player
    {
        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime birthDate;
        private Team team;

        public Player(string fname, string lname, decimal salary, DateTime birth) 
            : this(fname, lname, salary, birth, null)
        {
        }

        public Player(string fname, string lname, decimal salary, DateTime birth, Team team)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Salary = salary;
            this.BirthDate = birth;
            this.Team = team;
        }


        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("First Name is required and should be at least 3 characters.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Last Name is required and should be at least 3 characters.");
                }
                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }
                this.salary = value;
            }
        }

        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set
            {
                if (value.Year < 1980)
                {
                    throw new ArgumentOutOfRangeException("Date of Birth’s year cannot be lower than 1980.");
                }
                this.birthDate = value;
            }
        }

        public Team Team
        {
            get { return this.team; }
            set { this.team = value; }
        }

        public override string ToString()
        {
            return string.Format("Player details:{0} {1}/ salary: {2} / date of birth: {3} / team: {4}",
                                this.FirstName, this.LastName, this.Salary, this.BirthDate, this.Team.ToString() ?? "N/A");
        }

    }
}
