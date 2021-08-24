using System;

namespace Rental_Car
{


    //---DRIVER CLASS---//
    class Sudo
    {
        // creating object of derived class
        Car ObjC2 = new Car("", "", "", 77, true);
        Customer cus = new Customer();
        int choice=0;
        bool trigger = false;

        Sudo()
        {

        }
        void menu()
        {
            do
            {
                Console.WriteLine("----------- Car Rental System -----------");
                Console.WriteLine("[1] List all customers");
                Console.WriteLine("[2] List all cars");
                Console.WriteLine("[3] Register customer");
                Console.WriteLine("[4] List all available cars");
                Console.WriteLine("[5] Rent a car");
                Console.WriteLine("[6] List all rental details for all Saloons or Mpvs");
                Console.WriteLine("[7] Return a car ");
                Console.WriteLine("[8] List rental details for a customer over a period ");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("----------- Car Rental System -----------");
                Console.Write("Please Enter Your Choice: ");
                choice = int.Parse(Console.ReadLine());


                //Console.Write("You Entered: " + choice);

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("-----------List of all customers-----------");
                            cus.readrecordCus();
                            Console.WriteLine("Press Enter: ");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("------------List of all Cars-------------");
                            Car ObjC2 = new Car("", "", "", 99, false);
                            Console.WriteLine("Press Enter: ");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("In Register customer SubMenu:");
                            //cus.register();
                            Console.Write("Enter ID(4Digit): ");
                            int x;
                            x = int.Parse(Console.ReadLine());
                            Console.Write("Enter NAME: ");
                            string y;
                            y = Console.ReadLine();
                            Console.Write("Enter Tel No(8Digit): ");
                            string z;
                            z = Console.ReadLine();
                            Customer Cus2 = new Customer(x, y, z);
                            Console.WriteLine("Press Enter: ");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("----------List of all Available Cars----------");
                            ObjC2.fun();
                            Console.WriteLine("Press Enter: ");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("-----------Rent A Car-----------");
                            cus.readrecordCus();
                            Console.Write("Enter S/No of Customer    :");
                            int x = int.Parse(Console.ReadLine());
                            Car ObjC2 = new Car("", "", "", x, false);
                            Console.WriteLine("Press Enter: ");
                            Console.ReadKey();
                            break;
                        }

                    case 6:
                        {
                            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\IrfanPC\source\repos\Rental Car\Rental Car\record.csv");
                            try
                            {
                                for (int i = 0; i < lines.Length; i++)
                                {
                                    Console.WriteLine(lines[i]);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error in Program" + ex);
                                throw new AccessViolationException("Error: " + ex);
                            }
                            Console.WriteLine("Press Enter: ");
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            string x;
                            Console.Write("Enter Rentel No: ");
                            x = Console.ReadLine();
                            Console.Write("Enter Customer Name: ");
                            x = Console.ReadLine();
                            Console.WriteLine("Press Enter: ");
                            break;
                        }
                    case 8:
                        {
                            saloon s = new saloon();
                            Console.WriteLine("Press Enter: ");
                            Console.ReadKey();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("You Exited Program:");
                            trigger = true;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (trigger!=true);
        }

        // Main Method
        static void Main(string[] args)
        {
            Sudo s = new Sudo();
            s.menu();


        }
    }


}
