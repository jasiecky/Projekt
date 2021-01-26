using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ListaKupno
    {
        private Kupno kupno;
        private List<Kupno> kupna;

        public Kupno Kupno
        {
            get
            {
                return kupno;
            }
            set
            {
                kupno = value;
            }
        }
        public List<Kupno> Kupna
        {
            get
            {
                return kupna;
            }
            set
            {
                kupna = value;
            }
        }

        public ListaKupno(Kupno kupno)
        {
            Kupna = new List<Kupno>();
            this.kupno = new Kupno();
        }

        public void Dodaj(Kupno kupno)
        {
            this.kupna.Add(kupno);
        }

        public void Wyczysc()
        {
            this.kupna.Clear();
        }
    }
}
