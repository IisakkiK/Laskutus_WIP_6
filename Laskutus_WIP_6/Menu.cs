using System;

namespace Laskutus_WIP_5
{
    class Menu
    {
        /// <summary>
        /// Muuttujat
        /// </summary>
        public string FirstMenuItem { get; set; }
        public string SecondMenuItem { get; set; }
        public string ThirdMenuItem { get; set; }
        public string FourthMenuItem { get; set; }
        public string FifthMenuItem { get; set; }

        /// <summary>
        /// Constructori
        /// </summary>
        /// <param name="firstMenuItem"></param>
        /// <param name="secondMenuItem"></param>
        /// <param name="thirdMenuItem"></param>
        /// <param name="fourthMenuItem"></param>
        /// <param name="fifthMenuItem"></param>
        public Menu(string firstMenuItem, string secondMenuItem, string thirdMenuItem, string fourthMenuItem, string fifthMenuItem)
        {
            FirstMenuItem = firstMenuItem;
            SecondMenuItem = secondMenuItem;
            ThirdMenuItem = thirdMenuItem;
            FourthMenuItem = fourthMenuItem;
            FifthMenuItem = fifthMenuItem;
        }

        /// <summary>
        /// Luo menun tämän classin muuttujille syötetyillä arvoilla.
        /// </summary>
        /// <returns>Menun, jossa on syötettyä määrää vastaava määrä itemeitä</returns>
        public string CreateMenu()
        {
            if ((FifthMenuItem == "") && (FourthMenuItem == "") && (ThirdMenuItem == "") && (SecondMenuItem == ""))
            {
                return FirstMenuItem;
            }
            else if ((FifthMenuItem == "") && (FourthMenuItem == "") && (ThirdMenuItem == ""))
            {
                return FirstMenuItem + "\n" + SecondMenuItem;
            }
            else if ((FifthMenuItem == "") && (FourthMenuItem == ""))
            {
                return FirstMenuItem + "\n" + SecondMenuItem + "\n" + ThirdMenuItem;
            }
            else if (FifthMenuItem == "")
            {
                return FirstMenuItem + "\n" + SecondMenuItem + "\n" + ThirdMenuItem + "\n" + FourthMenuItem;
            }
            else
            {
                return FirstMenuItem + "\n" + SecondMenuItem + "\n" + ThirdMenuItem + "\n" + FourthMenuItem + "\n" + FifthMenuItem;
            }
        }
    }
}
