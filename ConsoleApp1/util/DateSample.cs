using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.util
{
    class DateSample
    {
        public DateSample()
        {
            Console.WriteLine("DataSample");
            this.BasicFormat();
            this.AddSubtract();
            this.CompareDate();
        }

        public void BasicFormat()
        {
            DateTime dt = DateTime.Parse("1980/05/13");
            Console.WriteLine(dt.ToString("yyyyMMdd"));
            Console.WriteLine(dt.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);

            DateTime dt2 = DateTime.Parse("1980-05-13");
            Console.WriteLine(dt2);

            DateTime dt3 = new DateTime(1980, 5, 13, 12, 34, 56);
            Console.WriteLine(dt3.ToString("yyyy/MM/dd HH:mm:ss"));

            Console.WriteLine(dt3.Year);
            //曜日
            Console.WriteLine(dt3.DayOfWeek);
            
            DateTime tempDate = dt3.AddMonths(1);
            DateTime tempDate2 = new DateTime(tempDate.Year, tempDate.Month, 1);
            //月末
            DateTime lastDayOfMonth = tempDate2.AddDays(-1);
            Console.WriteLine(lastDayOfMonth);
        }

        public void AddSubtract()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.AddDays(10).ToString("yyyyMMdd"));

            DateTime dt2 = DateTime.Now;
            Console.WriteLine(dt2.AddMonths(-2).ToString("yyyyMMdd"));
        }
        
        public void CompareDate()
        {
            DateTime dt = new DateTime(1980, 5, 13);
            DateTime dt2 = DateTime.Now;

            TimeSpan diffDate = dt2 - dt;
            Console.WriteLine(diffDate.Days);

        }


    }
}
