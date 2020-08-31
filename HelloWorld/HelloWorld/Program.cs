using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Skriv ditt namn:");

            
            string userName = Console.ReadLine();


            Console.WriteLine("Du heter:" + userName);

        
            Console.WriteLine("Skriv din ålder:");


            int age = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Din ålder är: " + age);

            Console.WriteLine("Lever du: y/n");
            var answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine("Härligt att du lever");
            }
            else
            {
                Console.WriteLine("Tråkigt att du är död..Take the L");
            }





            Console.WriteLine("");
        }
    }
}
