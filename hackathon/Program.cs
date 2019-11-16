using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackathon
{
    static class Program
    {
        public static bool goronca1Wygrana = false;
        public static bool goronca2Wygrana = false;
        public static bool goronca3Wygrana = false;
        public static bool goronca4Wygrana = false;
        public static bool goronca5Wygrana = false;
        public static bool goronca6Wygrana = false;
        public static bool goronca7Wygrana = false;

        public static bool nowe1Wygrana = false;
        public static bool nowe2Wygrana = false;
        public static bool nowe3Wygrana = false;
        public static bool nowe4Wygrana = false;

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
