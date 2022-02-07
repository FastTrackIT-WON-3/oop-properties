using System;

namespace OopProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 2, 3, 4, 5 };
            MyCollection collection = new MyCollection(array);
            Console.WriteLine(collection[1]);

            int[,] elements = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9}
            };

            MyMatrix matrix = new MyMatrix(elements);
            Console.WriteLine(matrix[1, 2]);

            /*
            Person p = new Person("1234434343", new DateTime(1980, 2, 7));
            p.FirstName = "John";
            p.LastName = "Doe";
            p.SayHello();
            Console.WriteLine($"{p.FullName}");
            */
        }
    }
}
