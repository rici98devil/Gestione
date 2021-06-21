using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;



namespace Gestione
{
   static class Global

    {
        public static int riga;
        public static string Ricerca;
        public static string Destinazione;
        public static string Varie;
        public static string vita;
        public static string Matricola;
        public static string Descrizione;
        public static string Tipo;
        public static string VitaIniziale;
        public static bool salvataggio;
        public static string Risoluzione;
        public static string Min;
        public static string Max;
        public static string Fornitore;
        public static string Costrurrore;
        public static string Fdt;
        public static string Consegnato;
        public static string UltTaratura;
        public static string Nsch;
        public static string Scadenza;
        public static string Causa;
        public static string Note;
        public static string Unita;
        public static string Uso;
        public static string Id;
        public static bool Completa;
    }
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
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
