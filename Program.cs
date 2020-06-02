using System;

namespace ConsoleApp2
{
    class Practic_task2
    {
        static void Main(string[] args)
        {
            String a;
            Console.WriteLine("Enter Input Match String ");
           
            a = Console.ReadLine(); 

            {
                if (a == "morning")
                {

                    Console.WriteLine("good morning ");
                }

                else if (a == "afternoon")
                {

                    Console.WriteLine("Good Afternoon");
                }
                else 
                {

                    Console.WriteLine("Good Night");
                }
            }
        }
    }
}

