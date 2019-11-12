using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betoltes_Mentes
{
    class Szemely
    {
        string nev;
        bool nem;
        DateTime szulido;
        string[] hobbik;
        bool feliratkozik;


        public bool Feliratkozik { get => feliratkozik; set => feliratkozik = value; }
        public string Nev { get => nev; set => nev = value; }
        public bool Nem { get => nem; set => nem = value; }
        public DateTime Szulido { get => szulido; set => szulido = value; }
        public string[] Hobbik { get => hobbik; set => hobbik = value; }

        public Szemely(string nev, bool nem, DateTime szulido, bool feliratkozik, string[] hobbik)
        {
            this.nev = nev;
            this.nem = nem;
            this.szulido = szulido;
            this.feliratkozik = feliratkozik;
            this.hobbik = hobbik;
        }

        public Szemely()
        {
        }

        public string toXML()
        {
            string toXML = "";
            return toXML;
        }

        public void fromXML(string adat)
        {

        }
        public string toTXT()
        {
            string toTXT = string.Join(";", nev, szulido.ToString("yyyy-MM-dd"), nem.ToString(), feliratkozik.ToString(), string.Join(";",hobbik));
            return toTXT;
        }
        public bool fromTXT(string sor)
        {
            bool sikeres = true;
            try
            {
                string[] adat = sor.Split(';');
                nev = adat[0];
                szulido = DateTime.Parse(adat[1]);
                nem = bool.Parse(adat[2]);
                feliratkozik = bool.Parse(adat[3]);
                hobbik = new string[adat.Length - 4];
                Array.Copy(adat, 4, hobbik, 0, adat.Length - 4);
            }
            catch (Exception ex)
            {
                sikeres = false;
            }
            return sikeres;
        }

    }
}
