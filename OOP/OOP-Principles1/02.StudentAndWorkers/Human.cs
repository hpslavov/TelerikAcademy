namespace _02.StudentAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Human
    {

        private string firstName;
        private string lastName;

        public Human(string firsName,string lastName)
        {
            this.FirstName = firsName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get { return this.firstName; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.lastName = value;
            }
        }


    }
}
