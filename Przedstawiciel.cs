using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace WindowsFormsApp1
{
    /// <summary>
    /// Informacje o przedstawicielu handlowym
    /// </summary>
	public class Przedstawiciel : Osoba
    {
        private string branza;

        /// <summary>
        /// Inicjalizacja nowego obiektu klasy <see cref="Przedstawiciel" />
        /// </summary>
        public Przedstawiciel()
        {
            this.branza = null;
        }

        /// <summary>
        /// Inicjalizacja nowego obiektu klasy <see cref="Przedstawiciel" />
        /// </summary>
        /// <param name="imie">Imie</param>
        /// <param name="nazwisko">Nazwisko</param>
        /// <param name="numer_telefonu">Numer telefonu</param>
        /// <param name="pesel">PESEL</param>
        /// <param name="branza">Branża</param>
        public Przedstawiciel(string imie, string nazwisko, string numer_telefonu, string pesel, string branza) : base(imie, nazwisko, numer_telefonu, pesel)
		{
            this.branza = branza;
        }
        public string Branza 
        { 
            get 
            { 
                return branza; 
            } 
            set 
            { 
                branza = value; 
            } 
        }

        /// <summary>
        /// Wyświetlanie danych o obiekcie
        /// </summary>
        /// <returns><see cref="System.String" /> z informacjami o obiekcie</returns>
        public override string WyswietlDane()
        {
            return "Imie: " + this.Imie + " Nazwisko: " + this.Nazwisko + " Pesel: " + this.Pesel + " Numer telefonu: " + this.Numer_telefonu +" Branża: " + this.branza;
        }
        /// <summary>
        /// Zapis obiketu do pliku XML
        /// </summary>
        public void SerializacjaXML()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Przedstawiciel));
            using (Stream s = File.Create("przedstawiciel.xml"))
            xs.Serialize(s, this);
        }
        /// <summary>
        /// Odczyt obiektu z pliku XML
        /// </summary>
        /// <param name="nazwa">Nazwa pliku</param>
        /// <returns>Obiekt klasy <see cref="Przedstawiciel" /></returns>
        public static Przedstawiciel DeserializacjaXML(string nazwa)
        {
            Przedstawiciel odczyt = null;
            using (StreamReader reader = new StreamReader(nazwa))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Przedstawiciel));
                odczyt = serializer.Deserialize(reader) as Przedstawiciel;
            }
            return odczyt;
        }

        
        
    }

    
}
