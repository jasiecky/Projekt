using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

            //Testy
            //Tworzenie obiektow

            Przedstawiciel przedstawiciel1 = new Przedstawiciel("Jan", "Bach", "745678997", "98121508731", "rozrywkowa");
            Przedstawiciel przedstawiciel2 = new Przedstawiciel("Leo", "Messi", "654778997", "12030409845", "sportowa");
            Przedstawiciel przedstawiciel3 = new Przedstawiciel("Jan", "Bach", "604644545", "76121793321", "rozrywkowa");

            //Serializacja i deserializacja XML

            przedstawiciel1.SerializacjaXML();
            Przedstawiciel przedstawiciel4  = Przedstawiciel.DeserializacjaXML("przedstawiciel.xml");
            


            //Wyswietlanie danych
            przedstawiciel1.WyswietlDane();
    
        }
    }
}
