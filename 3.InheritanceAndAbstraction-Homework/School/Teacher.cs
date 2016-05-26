using System;
using System.Collections.Generic;
using System.Linq;


namespace School
{
    public class Teacher : Person, IDetails
    {
        private List<Discipline> disciplines;

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set { this.disciplines = value; }
        }

        public Discipline Discipline
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Teacher(string name, List<Discipline> disciplines, string details=null): base(name, details)
        {
            this.Disciplines = disciplines;
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public override string ToString()
        {
            string teacherInfo = string.Format("Teacher: {0} \nDetails: {1}", this.Name, this.Details);
            teacherInfo += string.Join("\n", this.Disciplines.Select(x => x.ToString()).ToArray());
            return teacherInfo;
        }
    }
}
