using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("How many students in you class?");
            var studentCount = int.Parse(Console.ReadLine());

            var studentNames = new string[studentCount];
            var studentGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name: ");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine("Student Grade: ");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name: {0}, Student Grade: {1}", studentNames[i], studentGrades[i]);
            }   
                Console.ReadLine();

        }
    }
}
