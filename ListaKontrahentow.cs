using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ListaKontrahentow
    {
        private Kontrahent kontrahent;
        private List<Kontrahent> kontrahenci;

        public Kontrahent Kontrahent
        {
            get
            {
                return kontrahent;
            }
            set
            {
                kontrahent = value;
            }
        }
        public List<Kontrahent> Kontrahenci 
        {
            get
            {
                return kontrahenci;
            }
            set
            {
                kontrahenci = value;
            }
        }

        public ListaKontrahentow(Kontrahent kontrahent)
        {
            Kontrahenci = new List<Kontrahent>();
            this.kontrahent = new Kontrahent();
        }

        public void Dodaj(Kontrahent kontr)
        {
            this.kontrahenci.Add(kontr);
        }


        
    }
}
