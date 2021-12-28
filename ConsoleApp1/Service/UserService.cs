using ConsoleApp1.db;
using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleApp1.Service
{
    class UserService
    {
        IDB idb;

        public UserService(IDB idb)
        {
            this.idb = idb;
        }

        public List<Users> getUsers()
        {
            this.idb.getConnetcString();
            string sql = "select * from users";
            DataTable dt = this.idb.select(sql);

            List<Users> users = new List<Users>();
            int rowNum = dt.Rows.Count;

            for (int rowIndex = 0; rowIndex < rowNum; ++rowIndex)
            {
                Users user = new Users();
                user.id = (int)dt.Rows[rowIndex]["id"];
                user.name = (string)dt.Rows[rowIndex]["name"];
                user.sex = (int)dt.Rows[rowIndex]["sex"];
                user.birthday = (DateTime)dt.Rows[rowIndex]["birthday"];

                users.Add(user);
            }

            return users;
        }


    }
}
