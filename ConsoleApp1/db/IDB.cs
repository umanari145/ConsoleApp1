using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleApp1.db
{
    public interface IDB
    {
        string getConnetcString();

        void connect();

        DataTable select (string sql);

    }
}
