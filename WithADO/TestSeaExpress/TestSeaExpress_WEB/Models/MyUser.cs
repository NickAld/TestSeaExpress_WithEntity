using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using DataBase;

namespace TestSeaExpress_WEB
{
    public class MyUser : Person
    {
        public MyUser()
        {
            isNew = true;
        }

        public bool isNew {get;set;}
    }
}