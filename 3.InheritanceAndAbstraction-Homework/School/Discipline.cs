using System;
using System.Collections.Generic;
using System.Linq;


namespace School
{
    public class Discipline : IDetails
    {
        private string name;
        private int numOfLectures;
        private List<Student> students;
        private string details;

        public string Name
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty.");
                }
                this.name = value;
            }
        }

        public int NumOfLectures
        {
            get { return this.numOfLectures; }
            set
            {
                if(value < 0 || value == null)
                {
                    throw new ArgumentException("Number of lectures cannot be empty or negative.");
                }
                this.numOfLectures = value;
            }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
        
        
        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        public Discipline(string name, int lecturesNumber, List<Student> students, string details = null)
        {
            this.Name = name;
            this.NumOfLectures = lecturesNumber;
            this.Students = students;
            this.Details = details;
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public override string ToString()
        {
            string disciplineInfo = string.Format("Subject: {0} \nNumber of lectures: {1} \nDetails: {2} \nStudents: ",
                                                                        this.Name, this.NumOfLectures, this.Details);
            disciplineInfo += string.Join("\n", this.Students.Select(x => x.ToString()).ToArray());
            return disciplineInfo;
        }
    }
}
