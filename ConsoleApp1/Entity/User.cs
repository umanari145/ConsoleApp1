using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entity
{
    class User
    {
        public int id { get; set; }
        public string name { get; set; }

        public string pref { get; set; }
        public byte sex { get; set; }
        public DateTime birthday { get; set; }
    }
}
