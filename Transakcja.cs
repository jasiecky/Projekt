using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public abstract class Transakcja
	{
		private int kwota;
		private Przedstawiciel przedstawiciel;
		private Kontrahent kontrahent;
		private DateTime data;

		public Transakcja()
		{
			this.kwota = 0;
			this.przedstawiciel = null;
			this.kontrahent = null;
			this.data = DateTime.Today;
		}
		public Transakcja(int kwota, Przedstawiciel przedstawiciel, Kontrahent kontrahent, DateTime data)
		{
			this.kwota = kwota;
			this.przedstawiciel = przedstawiciel;
			this.kontrahent = kontrahent;
			this.data = data;
		}

		public int Kwota
		{
			get
			{
				return kwota;
			}

			set
			{
				Kwota = value;
			}
		}

		public Przedstawiciel Przedstawiciel
		{
			get
			{
				return przedstawiciel;
			}

			set
			{
				Przedstawiciel = value;
			}
		}

		public Kontrahent Kontrahent
		{
			get
			{
				return kontrahent;
			}

			set
			{
				Kontrahent = value;
			}
		}

		public DateTime Data
		{
			get
			{
				return data;
			}

			set
			{
				Data = value;
			}
		}
		public string WyswietlInformacje()
		{
			return "Kwota: " + this.kwota.ToString() + " Przedstawiciel: " + this.przedstawiciel.Imie + this.przedstawiciel.Nazwisko + " Kontrahent: " + this.kontrahent.Imie + this.kontrahent.Nazwisko + " Data: " + this.data;
		}
	}

	

}
