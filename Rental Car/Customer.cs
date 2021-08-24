using System;
using System.Collections.Generic;
using System.Text;

namespace Rental_Car
{
    //---CLASS 2---//
    class Customer
    {
        private int[] Id = new int[10];
        private string[] Name = new string[10];
        private string[] Tel = new string[10];

        public Customer()
        {

        }

        public Customer(int id, string name, string tel)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\IrfanPC\source\repos\Rental Car\Rental Car\customerid.csv", true))
                {
                    file.WriteLine(id + "," + name + "," + tel);
                }
                Console.WriteLine("Data Written Succesfully");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Oopsie in Program: ", ex);
            }
        }

        public string[] readrecordCus() //Reading CustomerCsv
        {
            string[] id_ = new string[10];
            string[] name_ = new string[10];
            string[] tel_ = new string[10];
            string[] linesCus = System.IO.File.ReadAllLines(@"C:\Users\IrfanPC\source\repos\Rental Car\Rental Car\customerid.csv");

            string[] recordNotFound = { " Record not Found " };
            //Customer Reader//
            try
            {
                string[] fields = linesCus[0].Split(',');
                //Console.WriteLine(string.Join("|", fields));
                id_[0] = fields[0];
                name_[0] = fields[1];
                tel_[0] = fields[2];
                Console.WriteLine(id_[0] + "    " + name_[0] + "   " + tel_[0]);

                for (int i = 1; i < linesCus.Length; i++)
                {
                    fields = linesCus[i].Split(',');
                    //Console.WriteLine(string.Join("|", fields));
                    id_[i] = fields[0];
                    name_[i] = fields[1];
                    tel_[i] = fields[2];
                    Console.WriteLine((i) + ") " + id_[i] + " " + name_[i] + " " + tel_[i]);
                }

                return recordNotFound;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CusProgram" + ex);
                return recordNotFound;
                throw new AccessViolationException("Error: " + ex);

            }
        }
    }

}
