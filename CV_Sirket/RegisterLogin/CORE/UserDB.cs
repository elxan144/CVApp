using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegisterLogin.Model;

namespace RegisterLogin.CORE
{
     static class UserDB
    {

        public static ArrayList users = new ArrayList();
        public static int count=0;


        public static void AddUser(User user )
        {
            users.Add(user);
            count++;
        }



        public static bool LoginCheck(LoginUser logUser)
        {
            bool result = false;

            foreach (User item in users)
            {
                if (item.email == logUser.email)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }


    }
}
