using System;
using System.Collections.Generic;
using System.Text;

namespace Rental_Car
{
    //---CLASS 3---//
    class mvp : Car
    {
        int chauffeur;
        public mvp()
        {
            string field = "";

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
        }
        public mvp(string model, string make, string name, int chauffeur_, bool avaiable)
        {
            this.chauffeur = chauffeur_;
        }
        double CalculateCharges()
        {
            double ratess;

            for (int i = 0; i < 10; i++)
            {
                ratess = +1;
            }
            return 1;
        }
        void toString()
        {
            Console.WriteLine("no of chauffeur: " + chauffeur);
        }
    }

}
