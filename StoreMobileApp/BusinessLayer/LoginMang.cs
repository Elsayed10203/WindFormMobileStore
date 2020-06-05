using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMobileApp
{
  static  class  LoginMang
    {
        static Model1 DB = new Model1();
        public static Users LoginNAME()
        {
            Users usr = DB.Users.Where(X => X.UserName == Program.UserLogin && X.UserPassword == Program.UserPass).SingleOrDefault();
            return usr;
        }
     
    }
}
