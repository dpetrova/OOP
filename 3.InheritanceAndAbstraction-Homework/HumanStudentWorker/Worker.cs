using System;


namespace HumanStudentWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string fname, string lname, decimal weekSalary, int workHours)
            : base(fname, lname)
        {
            this.WeekSlary = weekSalary;
            this.WorkHoursPerDay = workHours;
        }


        public decimal WeekSlary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("The salary cannot be negative.");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("The work hours cannot be negative.");
                }
                this.workHoursPerDay = value;
            }
        }
        

        public decimal MoneyPerHour()
        {
            int weekWorkHours = workHoursPerDay * 5;
            decimal moneyPerHour = weekSalary / weekWorkHours;
            return moneyPerHour;
        }

        public override string ToString()
        {
            return base.ToString() + "; Money per hour: " + this.MoneyPerHour().ToString("F2");
        }
    }
}
