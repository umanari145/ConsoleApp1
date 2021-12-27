using ConsoleApp1.db;
using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Service
{
    class UserService
    {
        public UserService()
        {

        }

        public List<Users> getUsers()
        {
            IDB idb = new ORMDataBase();
            idb.getConnetcString();
            List<Users> users = idb.select();

            return users;
        }
    }
}
