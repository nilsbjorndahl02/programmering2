using System;

    namespace LabbOOP
    {
        class Program
        {
            static void Main(string[] args)
            {
                Customer customer1 = new Customer();
                Console.WriteLine("Enter Customer's name");
                customer1._name = Console.ReadLine();



                Products products = new Products();
                ProductChild orange = new ProductChild();
                ProductChild cat = new ProductChild();


                Boolean case3 = true;

                while (case3)
                {

                    Console.WriteLine("Click 1 to chosse Orange");
                    Console.WriteLine("Click 2 to chosse Cat");
                    Console.WriteLine("Click 3 to exit");
                    var customerInput = Convert.ToInt32(Console.ReadLine());

                    switch (customerInput)
                    {
                        case 1:
                            Console.WriteLine("click 1 for rotten orange");
                            Console.WriteLine("click 2 for perfect orange");
                            var customerInput2 = Convert.ToInt32(Console.ReadLine());

                            switch (customerInput2)
                            {
                                case 1:

                                    customer1._cart.Add(orange._rotttenorange);
                                    break;

                                case 2:
                                    customer1._cart.Add(orange._perfectorange);
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("click 1 for black cat");
                            Console.WriteLine("click 2 for gray cat");
                            var customerInput3 = Convert.ToInt32(Console.Read());

                            switch (customerInput3)
                            {

                                case 2:
                                    customer1._cart.Add(cat._blackcat);
                                    break;

                                case 4:
                                    customer1._cart.Add(cat._graycat);


                                    break;
                            }
                            break;

                        case 3:
                            case3 = false;
                            Console.WriteLine("Exiting");
                            break;

                        default:
                            Console.WriteLine("wrong input");
                            break;




                    }

                    foreach (var i in customer1._cart)
                    {
                        Console.WriteLine(i);
                    }



                }









            }
        }
    }
