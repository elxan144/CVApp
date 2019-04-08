using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            USer usr = new USer();
            usr.name = "sas";
            usr.surname = "sasasas";
            usr.email = "sasa@@";

            USer usr2 = new USer();
            usr2.name = "jk";
            usr2.surname = "kjasn";
            usr2.email = "k@@";

            ArrayList arr = new ArrayList();

            arr.Add(usr);
            arr.Add(usr2);




            Console.ReadLine();

        }
    }
}
