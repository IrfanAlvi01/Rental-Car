using System;
using System.Collections.Generic;
using System.Text;

namespace Rental_Car
{
    //---CLASS 1---//
    class Car
    {
        // data members
        private string[] CarId = new string[15];
        private string[] Make = new string[15];
        private string[] Model = new string[15];
        private string[] Rate = new string[15];
        private bool[] Available = new bool[15];

        int[] sr = new int[10];
        int count = 0;
        string[] type_ = new string[15];
        string[] childseat_ = new string[15];
        string[] chauf_ = new string[15];
        // class constructor
        public Car()
        {


        }
        public Car(string carid, string make, string model, int rate, bool available)
        {

            if (rate == 77)
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\IrfanPC\source\repos\Rental Car\Rental Car\Attach.csv");
                try
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(',');
                        type_[i] = fields[0];
                        CarId[i] = fields[1];
                        Make[i] = fields[2];
                        Model[i] = fields[3];
                        //if (i != 0)
                        //    rate_[i] = Int32.Parse(fields[4]);
                        Rate[i] = fields[4];
                        if (i != 0)
                        {
                            if (fields[5] == "Yes")
                                Available[i] = true;
                            else
                                Available[i] = false;
                        }
                        childseat_[i] = fields[6];
                        chauf_[i] = fields[7];
                        //Console.WriteLine(toString(type_[i]) + toString(CarId[i]) + toString(Make[i]) + toString(Model[i]) + toString(Rate[i])
                        //                   + toString(fields[5]) + toString(childseat_[i]) + toString(chauf_[i]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in Program" + ex);
                    throw new AccessViolationException("Error: " + ex);
                }
            }

            if (rate == 88)
            {

            }

            if (rate == 99)
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\IrfanPC\source\repos\Rental Car\Rental Car\Attach.csv");
                try
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(',');
                        type_[i] = fields[0];
                        CarId[i] = fields[1];
                        Make[i] = fields[2];
                        Model[i] = fields[3];
                        Rate[i] = fields[4];
                        if (i != 0)
                        {
                            if (fields[5] == "Yes")
                                Available[i] = true;
                            else
                                Available[i] = false;
                        }
                        childseat_[i] = fields[6];
                        chauf_[i] = fields[7];
                        Console.WriteLine(toString((i + 1).ToString()) + ") " + toString(type_[i]) + toString(CarId[i]) + toString(Make[i]) + toString(Model[i]) + toString(Rate[i])
                                           + toString(fields[5]) + toString(childseat_[i]) + toString(chauf_[i]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in Program" + ex);
                    throw new AccessViolationException("Error: " + ex);
                }
            }

            if (rate >= 0 && rate <= 10)
            {
                sr[count] = rate;
                count++;
                Customer c = new Customer();
                Car ObjC2 = new Car("", "", "", 99, false);
                Console.Write("Enter S/No of Car         :");
                int y = int.Parse(Console.ReadLine());
                Available[y] = false;

                Console.Write("Enter Start Date (mm–dd–yyyy): ");
                DateTime SD = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter End Date (mm–dd–yyyy): ");
                DateTime ED = DateTime.Parse(Console.ReadLine());
                Rental ren = new Rental(y, ObjC2, c, SD, ED);

            }
        }

        // public method of base class 
        public double CalculateCharges()
        {
            return 0;
        }

        public void fun()
        {
            string xx = "x";
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\IrfanPC\source\repos\Rental Car\Rental Car\Attach.csv");
            try
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i != 0)
                    {
                        if (Available[i] == true)
                            xx = "Yes";
                        else
                            xx = "No";
                    }
                    Console.WriteLine(toString((i + 1).ToString()) + ") " + toString(type_[i]) + toString(CarId[i]) + toString(Make[i]) + toString(Model[i]) + toString(Rate[i])
                                       + toString(xx));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Program" + ex);
                throw new AccessViolationException("Error: " + ex);
            }
        }

        public string toString(string x)
        {
            if (x.Length == 1)
            {
                x = " " + x;
                return x;
            }
            if (x == "10")
                return x;
            if (x.Length == 2)
            {
                x = x + "       ";
                return x;
            }
            if (x.Length == 3)
            {
                x = x + "      ";
                return x;
            }
            if (x.Length == 4)
            {
                x = x + "     ";
                return x;
            }
            if (x.Length == 5)
            {
                x = x + "    ";
                return x;
            }
            if (x.Length == 6)
            {
                x = x + "   ";
                return x;
            }
            if (x.Length == 7)
            {
                x = x + "  ";
                return x;
            }
            if (x.Length == 8)
            {
                x = x + " ";
                return x;
            }
            if (x == "")
                x = "        ";
            return x;
        }
    }


}
