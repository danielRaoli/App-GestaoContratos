using System;


namespace Curso4.Entities
{
   class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; private set; }
        public int Hours { get; set; }


        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }


        public double TotalValue()
        {
            return ValuePerHour*Hours;
        }
    }
}
