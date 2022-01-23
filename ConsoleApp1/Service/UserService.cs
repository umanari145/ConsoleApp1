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

        public List<User> getUsers()
        {
            this.idb.getConnetcString();
            string sql = "select * from users";
            DataTable dt = this.idb.select(sql);

            List<User> users = new List<User>();
            int rowNum = dt.Rows.Count;

            for (int rowIndex = 0; rowIndex < rowNum; ++rowIndex)
            {
                User user = new User();
                user.id = (int)dt.Rows[rowIndex]["id"];
                user.name = (string)dt.Rows[rowIndex]["name"];
                user.sex = (byte)dt.Rows[rowIndex]["sex"];
                user.birthday = (DateTime)dt.Rows[rowIndex]["birthday"];

                users.Add(user);
            }

            return users;
        }

    }
}
