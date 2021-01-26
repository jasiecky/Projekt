using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ListaSprzedaz
    {
        private Sprzedaz sprzedaz;
        private List<Sprzedaz> sprzedane;

        public Sprzedaz Sprzedaz
        {
            get
            {
                return sprzedaz;
            }
            set
            {
                sprzedaz = value;
            }
        }
        public List<Sprzedaz> Sprzedane
        {
            get
            {
                return sprzedane;
            }
            set
            {
                sprzedane = value;
            }
        }

        public ListaSprzedaz(Sprzedaz sprzedane)
        {
            Sprzedane = new List<Sprzedaz>();
            this.sprzedaz = new Sprzedaz();
        }

        public void Dodaj(Sprzedaz sprzedaz)
        {
            this.sprzedane.Add(sprzedaz);
        }

        public void Wyczysc()
        {
            this.sprzedane.Clear();
        }
    }
}
