using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	/// <summary>
	/// Klasa abstrakcyjna osoba
	/// </summary>
	public abstract class Osoba
	{
		private string imie;
		private string nazwisko;
		private string numer_telefonu;
		private string pesel;

		/// <summary>
		/// Inicjalizacja nowego obiektu klasy <see cref="Osoba" />
		/// </summary>
		public Osoba()
		{
			this.imie = null;
			this.nazwisko = null;
			this.numer_telefonu = null;
			this.pesel = null;
		}

		/// <summary>
		/// Inicjalizacja nowego obiektu klasy <see cref="Osoba" />
		/// </summary>
		/// <param name="imie">Imie</param>
		/// <param name="nazwisko">Nazwisko</param>
		/// <param name="numer_telefonu">Numer telefonu</param>
		/// <param name="pesel">PESEL</param>
		public Osoba(string imie, string nazwisko, string numer_telefonu, string pesel)
		{
			this.imie = imie;
			this.nazwisko = nazwisko;
			this.numer_telefonu = numer_telefonu;
			this.pesel = pesel;
		}

		public string Imie
		{
			get
			{
				return imie;
			}

			set
			{
				imie = value;
			}
		}

		public string Nazwisko
		{
			get
			{
				return nazwisko;
			}

			set
			{
				nazwisko = value;
			}
		}

		public string Numer_telefonu
		{
			get
			{
				return numer_telefonu;
			}

			set
			{
				numer_telefonu = value;
			}
		}

		public string Pesel 
		{ 
			get 
			{ 
				return pesel; 
			} 
			set 
			{ 
				pesel = value; 
			} 
		}

		/// <summary>
		/// Wyświetlanie danych o obiekcie
		/// </summary>
		/// <returns><see cref="System.String" /> z informacjami o obiekcie</returns>
		public virtual string WyswietlDane()
		{
			return "Imie: " + this.imie + " Nazwisko: " + this.nazwisko + " Numer telefonu: " + this.numer_telefonu;
		}
		
	}

}
