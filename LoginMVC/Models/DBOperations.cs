using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginMVC.Models
{
    public class DBOperations
    {
        static ADODBEntities1 a = new ADODBEntities1();

        public static bool Login(Login L)
        {
            
            var l = from i in a.Logins
                    where i.username == L.username && i.password == L.password
                    select i;
            if (l.Count() == 1)
                return true;
            else 
                return false;
        }
    }
}