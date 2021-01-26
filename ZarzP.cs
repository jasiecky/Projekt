using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace WindowsFormsApp1
{
    public partial class ZarzP : Form
    {
        public ZarzP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void DodajXML_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tImie.Text) || string.IsNullOrEmpty(tNazwisko.Text) || string.IsNullOrEmpty(mtNumerTelefonu.Text) || string.IsNullOrEmpty(tPesel.Text) || string.IsNullOrEmpty(tBranza.Text))
            {
                MessageBox.Show("Proszę podać wszystkie dane!");
            }
            else
            {

                Regex wzorzec = new Regex("^\\d{11}$");
                if (wzorzec.IsMatch(tPesel.Text))
                {
                    Przedstawiciel przed = new Przedstawiciel(tImie.Text, tNazwisko.Text, mtNumerTelefonu.Text, tPesel.Text, tBranza.Text);
                    if (Lista.Items.Contains(przed)==false)
                    {                        
                        przed.SerializacjaXML();
                        Lista.Items.Add(przed);
                        tImie.Text = "";
                        tNazwisko.Text = "";
                        mtNumerTelefonu.Text = "";
                        tPesel.Text = "";
                        tBranza.Text = "";
                        MessageBox.Show("Dodano przedstawiciela i zapisano w pliku XML!");
                    }else
                    {
                        MessageBox.Show("Podany przedstawiciel już istnieje!");
                    }
                }
                else
                {
                    MessageBox.Show("Proszę podać poprawny numer PESEL!");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tXML.Text))
            {
                MessageBox.Show("Proszę podać nazwę pliku!");
            }
            else
            {
                Przedstawiciel przed = Przedstawiciel.DeserializacjaXML(tXML.Text);
                Lista.Items.Add(przed);
                MessageBox.Show("Dodano przedstawiciela!");
            }
        }

       

        private void Usun_Click(object sender, EventArgs e)
        {
            int i = Lista.SelectedIndex;
            if(i!=1)
            {
                Lista.Items.RemoveAt(i);
                MessageBox.Show("Usunięto przedstawiciela!");
            }
            else 
            {
                MessageBox.Show("Nie wybrano przedstawiciela!");
            }
        }

        private void WyswietlDane_Click(object sender, EventArgs e)
        {
            int j = Lista.SelectedIndex;
            if (j != 1)
            {
                Przedstawiciel i = (Przedstawiciel)Lista.SelectedItem;
                MessageBox.Show(i.WyswietlDane());
            }
            else
            {
                MessageBox.Show("Nie wybrano przedstawiciela!");
            }
            
            
        }
    }
}
