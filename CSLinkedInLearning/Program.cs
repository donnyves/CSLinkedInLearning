using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLinkedInLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();
        


            Console.WriteLine("What is your age?");
            var age = TryAnswer();

        
            

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer();

         
       


            Console.WriteLine($"Hi {name}, you are {age} years old and you were born in {month}");
        }

        static string TryAnswer()
        {

            var answer = Console.ReadLine();

            if (answer == "")
            {
                Console.WriteLine("You did not type anthing, please try again");
                return Console.ReadLine();
            }
            return answer;
        }     
    }
}