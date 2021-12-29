using ConsoleApp1.Entity;
using System;
using System.Data.SqlClient;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data;
using System.Configuration;

namespace ConsoleApp1.db
{
    public class ORMDataBase : IDB
    {
        private string connectString;

        private SqlConnection conn;

        public string getConnetcString()
        {
            string connectString = ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString;
            return connectString;
        }

        public void connect()
        {
            this.connectString = this.getConnetcString();
            try
            {
                this.conn = new SqlConnection(this.connectString);
            }
            catch (Exception e)
            {
                throw new SystemException("DB接続に失敗しました。");
            }
        }


        public DataTable select(string sql)
        {
            /*DI的な作りにしようとしたが失敗・・・
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(this.conn, compiler);
            //コレクションで取得できる
            var users = db.Query("users")id", "name", "sex", "birthday")
                            .Get<Users>();
            */
            return new DataTable();
            
        }
    }
}
