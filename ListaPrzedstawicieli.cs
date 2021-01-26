using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ListaPrzedstawicieli
    {
        private Przedstawiciel przedstawiciel;
        private List<Przedstawiciel> przedstawiciele;

        public Przedstawiciel Przedstawiciel
        {
            get
            {
                return przedstawiciel;
            }
            set
            {
                przedstawiciel = value;
            }
        }
        public List<Przedstawiciel> Przedstawiciele
        {
            get
            {
                return przedstawiciele;
            }
            set
            {
                przedstawiciele = value;
            }
        }

        public ListaPrzedstawicieli(Przedstawiciel przedstawiciel)
        {
            Przedstawiciele = new List<Przedstawiciel>();
            this.przedstawiciel = new Przedstawiciel();
        }

        public void Dodaj(Przedstawiciel przedst)
        {
            this.przedstawiciele.Add(przedst);
        }

       
        
    }
}

