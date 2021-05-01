using ConsoleApp1.Entity;
using System;
using System.Data.SqlClient;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace ConsoleApp1.db
{
    class DataBase
    {
        private readonly string dbHost;

        private readonly string dbName;

        private readonly string dbUser;

        private readonly string dbPass;

        public DataBase(string dbHost, string dbName, string dbUser, string dbPass)
        {
            this.dbHost = dbHost;
            this.dbName = dbName;
            this.dbUser = dbUser;
            this.dbPass = dbPass;
            this.Connect();
        }

        private void Connect()
        {
            Console.WriteLine("aaaa");


            string connectionString = @"Data Source=" + this.dbHost + ";Initial Catalog=" + this.dbName + ";User ID=" + this.dbUser +";Password=" + this.dbPass;
            SqlConnection conn = new SqlConnection(connectionString);
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(conn, compiler);
            //コレクションで取得できる
            var users = db.Query("users").Select("id", "name", "sex", "birthday")
                          .Get<Users>();
        }
    }
}
