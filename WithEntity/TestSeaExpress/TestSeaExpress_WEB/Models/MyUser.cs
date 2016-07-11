using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSeaExpress_WEB
{
    public class MyUser : TestSeaExpress_WCF.User
    {
        public MyUser()
        {
            isNew = true;
        }

        public bool isNew {get;set;}
    }
}