using System;
using System.Collections.Generic;
using System.Text;

namespace Rental_Car
{
    //---CLASS 5---//
    class Rental
    {
        private int[] RentalNo = new int[10];
        private Car[] RentedCar = new Car[10];
        private Customer[] RentedBy = new Customer[10];
        private DateTime[] StartDate = new DateTime[10];
        private DateTime[] EndDate = new DateTime[10];
        int count = 0;
        public Rental()
        {
        }

        public Rental(int rentalno, Car rentedcar, Customer rentedby, DateTime startdate, DateTime enddate)
        {
            this.RentalNo[count] = rentalno;
            this.RentedCar[count] = rentedcar;
            this.RentedBy[count] = rentedby;
            this.StartDate[count] = startdate;
            this.EndDate[count] = enddate;
            count++;
            CalculateRentalCharges(rentalno, startdate, enddate);
        }
        public void CalculateRentalCharges(int R, DateTime startdate, DateTime enddate)
        {
            int[] Rate = new int[15];
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\IrfanPC\source\repos\Rental Car\Rental Car\Attach.csv");
            try
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    Rate[i] = Int32.Parse(fields[4]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Program" + ex);
                throw new AccessViolationException("Error: " + ex);
            }

            String diff2 = (enddate - startdate).TotalDays.ToString();
            Console.WriteLine("Total rental charges is $: " + (Rate[R] * Int32.Parse(diff2)));
        }
        public string ToString()
        {
            return null;
        }
    }
}
