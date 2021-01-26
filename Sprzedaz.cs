using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class Sprzedaz : Transakcja
	{
		private int zysk;

		public Sprzedaz()
		{
			this.zysk = 0;
		}
		public Sprzedaz(int kwota, Przedstawiciel przedstawiciel, Kontrahent kontrahent, DateTime data) : base(kwota, przedstawiciel, kontrahent, data)
		{
			this.zysk = kwota;
		}
		public int Zysk
		{
			get
			{
				return zysk;
			}

			set
			{
				Zysk = value;
			}
		}
	}


}
