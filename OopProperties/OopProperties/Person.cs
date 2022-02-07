using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProperties
{
    public class Person
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string cnp;
        private DateTime dateOfBirth;

        public Person(string cnp, DateTime dateOfBirth)
        {
            this.cnp = cnp;
            this.dateOfBirth = dateOfBirth;
        }

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value ?? string.Empty; }
        }

        public string LastName 
        {
            get { return lastName; }
            set { lastName = value ?? string.Empty; }
        }

        public string CNP 
        {
            get { return cnp; }
        }

        public DateTime DateOfBirth 
        {
            get { return dateOfBirth; }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}");
            Console.WriteLine($"My CNP is {CNP}");
            Console.WriteLine($"My date of birth is {DateOfBirth}");
        }
    }
}
