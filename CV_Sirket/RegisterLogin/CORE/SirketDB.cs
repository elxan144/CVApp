using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegisterLogin.Model;

namespace RegisterLogin.CORE
{
     static class SirketDB
    {

        public static ArrayList Vakansiyalar = new ArrayList();
        public static int countVakansiya = 0 ;


         static SirketDB()
        {
            SirketVakansiya sirket1 = new SirketVakansiya("Proqramci" , "2500", "PHP");
            SirketVakansiya sirket2 = new SirketVakansiya("Muhendis", "3000", "Avtocad");
            SirketVakansiya sirket3 = new SirketVakansiya("Elektrik", "1200", "Bacariqli");
            SirketVakansiya sirket4 = new SirketVakansiya("Ofisant", "600", "IngilisDili");

            Vakansiyalar.Add(sirket1);
            Vakansiyalar.Add(sirket2);
            Vakansiyalar.Add(sirket3);
            Vakansiyalar.Add(sirket4);

        }



        public static void AddVakansiya(SirketVakansiya sirket)
        {
            Vakansiyalar.Add(sirket);
            countVakansiya++;
        }
        
    }
}
