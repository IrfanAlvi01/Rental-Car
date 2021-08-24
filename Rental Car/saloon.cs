using System;
using System.Collections.Generic;
using System.Text;

namespace Rental_Car
{
    //---CLASS 4---//
    class saloon : Car
    {
        int childseat;
        public saloon()
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
        }
        public saloon(string model, string make, string name, int childseat_, bool avaiable)
        {
            this.childseat = childseat_;
        }
        void toString()
        {
            Console.WriteLine("no of chauffeur: ");
        }
    }
}
