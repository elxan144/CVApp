using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLogin.Model
{
    class SirketVakansiya
    {
        public string VakansiyaAdi;
        public string emekHaqqi;
        public string teleb;


        public SirketVakansiya( string VakansiyaAdi , string emekHaqqi , string teleb )
        {
            this.VakansiyaAdi = VakansiyaAdi;
            this.emekHaqqi = emekHaqqi;
            this.teleb = teleb;
        }
             
    }
}
