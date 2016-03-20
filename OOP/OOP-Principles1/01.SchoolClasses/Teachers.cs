namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Teacher : Discipline,IPerson
    {
        private List<Discipline> disciplines;
        
        public Teacher()
        {

        }
        public Teacher(string name, List<Discipline> disciplines)
        {
            this.Name = name;
            this.Disciplines = disciplines;
        }

        public string Name { get; private set; }
        

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            private set
            {
                this.disciplines = value;
            }
        }
        public void TellDiscipline()
        {
            foreach (var item in disciplines)
            {
                Console.Write(string.Join(", ", disciplines));
            }
        }

       
    }
}
