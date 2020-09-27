using System;

namespace Laskutus_WIP_5
{
    class Asiakas
    {
        /// <summary>
        /// Muuttujat
        /// </summary>
        public string Nimi { get; set; }
        public int Palvelutaso { get; set; }
        public int Laskutuskausi { get; set; }

        /// <summary>
        /// Constructori
        /// </summary>
        /// <param name="nimi"></param>
        /// <param name="ptaso"></param>
        /// <param name="lkausi"></param>
        public Asiakas(string nimi, int ptaso, int lkausi)
        {
            Nimi = nimi;
            Palvelutaso = ptaso;
            Laskutuskausi = lkausi;
        }

        /// <summary>
        /// ToString() -metodin override. Muotoiltu palauttamaan asiakkaan nimi ja parametrit
        /// </summary>
        /// <returns>Selkestäi muotoillun stringin asiakkaan nimestä ja parametreistä</returns>
        public override string ToString()
        {
            return "\nAsiakkaan nimi: " + Nimi + "\nPalvelutaso: " + Palvelutaso + "\nLaskutuskausi: " + Laskutuskausi;
        }
    }
}
