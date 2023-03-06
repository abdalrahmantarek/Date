using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    public class Date
    {
        private int Year;
        private int Month;
        private int Day;

        private readonly int []  Year365 =  {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        private readonly int [] Year366 =  { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        public Date(int Year, int Month, int Day)
        {
            var isleap = Year % 4==1 &&(Year %100 !=0 || Year % 400==0 );
            if (Year>=1&& Year <= 9999 && Month >= 1 && Month <= 12 && Day >=1 && Day <= 31)
            {
                int [] days = isleap ? Year365 : Year366;
                this.Year = Year;
                this.Month = Month;
                this.Day = Day;
            }
            else
            {
                Console.WriteLine("NV");
            }
            
            
        }
        // if user input only year
        public Date(int Year) : this(Year , 01 ,01) 
        {

        }
        public Date(int Year, int Month) : this(Year, Month, 01)
        {

        }

        public string getDate() 
        {
            return $" {Day.ToString().PadLeft(2,'0')}/{Month.ToString().PadLeft(2,'0')}/{Year.ToString().PadLeft(4,'0')}";
        }

    }
}
