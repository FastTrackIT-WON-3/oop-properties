using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProperties
{
    public class Person
    {
        public Person(string cnp, DateTime dateOfBirth)
        {
            this.CNP = cnp;
            this.DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string CNP 
        {
            get;
        }

        public DateTime DateOfBirth 
        {
            get;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {FullName}");
            Console.WriteLine($"My CNP is {CNP}");
            Console.WriteLine($"My date of birth is {DateOfBirth}");
        }

        public int GetAge(DateTime referenceDate)
        {
            return referenceDate.Year - DateOfBirth.Year;
        }
    }
}
