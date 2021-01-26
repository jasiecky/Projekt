using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace WindowsFormsApp1
{
	public class Kontrahent : Osoba
	{
        private string email;
        public Kontrahent()
        {
            this.email = null;
        }
        public Kontrahent(string imie, string nazwisko, string numer_telefonu, string pesel, string email) : base(imie, nazwisko, numer_telefonu, pesel)
		{
            this.email = email;
		}

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public void SerializacjaXML()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Kontrahent));
            using (Stream s = File.Create("kontrahent.xml"))
                xs.Serialize(s, this);
        }
        public static Kontrahent DeserializacjaXML(string nazwa)
        {
            Kontrahent odczyt = null;
            using (StreamReader reader = new StreamReader(nazwa))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Kontrahent));
                odczyt = serializer.Deserialize(reader) as Kontrahent;
            }
            return odczyt;
        }

        public int CompareTo(Kontrahent other)
        {
            if (this.Nazwisko != other.Nazwisko && this.Imie != other.Imie)
                return this.Nazwisko.CompareTo(other.Nazwisko);
            else
                return this.Pesel.CompareTo(other.Pesel);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
