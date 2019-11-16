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
        bool feliratkozik;
        DateTime szulido;
        string[] hobbik;


        public bool Feliratkozik { get => feliratkozik;  }
        public string Nev { get => nev; }
        public bool Nem { get => nem; }
        public DateTime Szulido { get => szulido;  }
        public string[] Hobbik { get => hobbik;  }

        /// <summary>
        ///     Az űrlap adatmezői alapján lehet létrehozni
        /// </summary>
        /// <param name="nev"></param>
        /// <param name="nem"></param>
        /// <param name="szulido"></param>
        /// <param name="feliratkozik"></param>
        /// <param name="hobbik"></param>
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

        /// <summary>
        ///     Struktúrált szövegfájlba íráshoz szükséges
        ///     XML-ról bővebben: http://www.w3c.hu/forditasok/XML_10_pontban.html
        /// </summary>
        /// <returns></returns>
        public string toXML()
        {
            string toXML = "";
            return toXML;
        }

        public void fromXML(string adat)
        {

        }
        /// <summary>
        ///     A szövegfájlba íráshoz szükséges metódus
        /// </summary>
        /// <returns></returns>
        public string toTXT()
        {
            string toTXT = string.Join(";", nev, szulido.ToString("yyyy-MM-dd"), nem.ToString(), feliratkozik.ToString(), string.Join(";",hobbik));
            return toTXT;
        }
        /// <summary>
        ///     Szövegfájlból visszatöltéshez szükséges
        /// </summary>
        /// <param name="sor">A visszaolvasott sor</param>
        /// <returns></returns>
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
