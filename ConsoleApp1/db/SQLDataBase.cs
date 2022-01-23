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
    class SQLDataBase : IDB
    {

        private SqlConnection con = null;

        public void connect()
        {
            if (this.con == null)
            {
                try
                {
                    string connectionStr = this.getConnetcString();
                    this.con = new SqlConnection(connectionStr);
                    this.con.Open();
                    Console.WriteLine("DBに接続します。");
                }
                catch(Exception e)
                {
                    throw new SystemException("DBに接続します。", e);
                }
            }
        }

        public string getConnetcString()
        {
            return ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString;
        }

        public DataTable select(string sql)
        {
            Console.WriteLine("SELECTを実行します。");
            try
            {
                this.connect();
                SqlCommand sqlCommand = new SqlCommand(sql, this.con);

                var dataAdapter = new SqlDataAdapter(sqlCommand);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e);
                throw new SystemException("Selectの実行に失敗しました。");
            }
            finally
            {
                this.con.Close();
                this.con.Dispose();
            }
        }

        public void GetSqlCommand(string sql)
        {
            this.connect();
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand(sql, this.con);
            sqlCommand.ExecuteNonQuery();
        }
    }
}
