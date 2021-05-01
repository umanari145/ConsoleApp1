using System;
using ConsoleApp1.db;
using ConsoleApp1.util;
using System.Configuration;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("本日!");
            //SchoolGetter c1 = new SchoolGetter();
            //c1.GetHTML();


            //CollectionSample cs = new CollectionSample();

            //DateSample ds = new DateSample();
            /*String dbHost = ConfigurationManager.AppSettings["dbHost"];
            DataBase db = new DataBase(
                ConfigurationManager.AppSettings["dbHost"],
                ConfigurationManager.AppSettings["dbName"],
                ConfigurationManager.AppSettings["dbUser"],
                ConfigurationManager.AppSettings["dbPass"]
            );*/

            FileSample fs = new FileSample();

        }
    }
}

