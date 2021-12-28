using ConsoleApp1.Entity;
using System;
using System.Data.SqlClient;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data;

namespace ConsoleApp1.db
{
    class SQLDataBase : IDB
    {
        public void connect()
        {
            string connectionString = @"Data Source=" + this.dbHost + ";Initial Catalog=" + this.dbName + ";User ID=" + this.dbUser + ";Password=" + this.dbPass;
            SqlConnection conn = new SqlConnection(connectionString);
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(conn, compiler);
            //コレクションで取得できる
            var users = db.Query("users").Select("id", "name", "sex", "birthday")
                          .Get<Users>();

        }

        public string getConnetcString()
        {
            throw new NotImplementedException();
        }

        public DataTable select(string sql)
        {
            throw new NotImplementedException();
        }

        private void Connect()
        {

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
