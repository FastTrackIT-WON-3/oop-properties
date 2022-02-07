using System;

namespace OopProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("1234434343", new DateTime(1980, 2, 7));
            p.FirstName = "John";
            p.LastName = "Doe";
            p.SayHello();
            // Console.WriteLine($"{p.CNP}");
        }
    }
}
