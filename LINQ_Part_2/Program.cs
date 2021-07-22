using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine("List of students: \n" + string.Join("\n", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(c => c.Students).OrderBy(s => s).ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
