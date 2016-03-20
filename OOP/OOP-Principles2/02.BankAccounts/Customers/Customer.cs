namespace _02.BankAccounts.Customers
{
    using System;
    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {

        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Customers name cannot be empty!");
                }
                this.name = value;
            }
        }

    }
}
