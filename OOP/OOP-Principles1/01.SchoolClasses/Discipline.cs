namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Discipline
    {
        private string nameOfDiscipline;
        private int numberOfLectures;
        private int numberOfExercies;

        public Discipline()
        {

        }
        public Discipline(string name,int lectures,int exercises)
        {
            this.NameOfDiscipline = name;
            this.NumberOfExercises = exercises;
            this.NuberOfLectures = lectures;
        }
        public string NameOfDiscipline
        {
            get { return this.nameOfDiscipline; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Discipline name cannot be empty!");
                }
                this.nameOfDiscipline = value;
            }
        }

        public int NuberOfLectures
        {
            get { return this.numberOfLectures; }
            private set
            {
                if (value == 0 || value < 0 )
                {
                    throw new ArgumentNullException("Disciplines number cannot be zero or less than zero");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercies; }

            private set
            {
                if (value == 0 || value <0)
                {
                    throw new ArgumentNullException("Exercises number cannot be zero or less than zero");
                }
                this.numberOfExercies = value;
            }
        }

        public override string ToString()
        {
            return this.nameOfDiscipline;
        }
    }
}
