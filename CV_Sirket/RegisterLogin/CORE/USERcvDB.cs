using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegisterLogin.Model;

namespace RegisterLogin.CORE
{
    static class USERcvDB
    {
        public static ArrayList usersCV = new ArrayList();
        public static int _count_ = 0;


        public static void AddCV(UserCV cv)
        {
            usersCV.Add(cv);
            _count_++;
        }
    }
}
