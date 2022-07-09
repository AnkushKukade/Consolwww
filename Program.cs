using System;

namespace Consolwww
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 By Default
            Console.WriteLine("Hello World!");
            Console.WriteLine("------------------------------");

            // 2 date time testing, string to “inject” the content in the right place at runtime…
            DateTime time = DateTime.Now;
            string name = "Jenny";
            int nFriends = 6;
            Console.WriteLine(
                "It's {0:HH:mm}, and {1} is here with {2} friends",
                time,
                name,
                nFriends
                );
            Console.WriteLine("------------------------------");

            // 3 format options to get neatly specified
            double pi = Math.PI;
            const int MAX_LENGTH = 20;
            Console.WriteLine(
                $"{pi,MAX_LENGTH}\n{pi,MAX_LENGTH:F3}"
                );
            Console.WriteLine("------------------------------");

            // 4
            Console.WriteLine(
                 $"\"Don Quixote\" isn't very nice to windmills :{{"
                 );
            Console.WriteLine("------------------------------");

            // 5 ForEach loop syntax demo
            string[] @for = new string[] { "Abe", "Bill", "cat", "Rasta" };
            foreach (string recipient in @for)
            {
                Console.WriteLine(recipient);
            }
            Console.WriteLine("------------------------------");

            // 6 Switch loop in C#

            int satisfaction = 7;
            Console.WriteLine(
              // "This person is {


                    satisfaction switch
                    {
                        > 8 => "super happy !",
                        > 6 => "super satifaed !",
                        > 4 => "in super doubt.... !",
                        > 2 => "just not ok !",
                        _ => "happy and sad !",
                    }
                   
                );
             
            Console.WriteLine("------------------------------");

        }
    }
}
