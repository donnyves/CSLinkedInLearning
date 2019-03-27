using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Collections_StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new List<string>();
            var studentGrades = new List<int>();
            var adding = true;

            while (adding)
            {
                Console.WriteLine("Student Name: ");
                studentNames.Add(Console.ReadLine());

                Console.WriteLine("Student Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Add another? y/n");
                if (Console.ReadLine() != "y")
                    adding = false;
            }
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Student Name: {0}, Student Grade: {1}", studentNames[i], studentGrades[i]);
            }
            Console.ReadKey();
        }
    }
}
