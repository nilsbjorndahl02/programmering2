using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
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



                    
                    
                    Console.WriteLine("Vänta tills den har räknat ner till noll");
                    for (int i = 5; i > -1; i--)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Nu får du välja, skriv nirvana eller återfödelse");
                    var end = Console.ReadLine();
                    switch (end)
                    {
                        case"nirvana":
                            Console.WriteLine("Du valde himmeln välkommen");
                            break;
                        case"återfödelse":
                            Console.WriteLine("Du valde helvetet grattis");
                            break;
                        default:
                            Console.WriteLine("Du valde inget synd för dig :/");
                            break;
                    }
                    break;
                }
            }
        }
    }
}
