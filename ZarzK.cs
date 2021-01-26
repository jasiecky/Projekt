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
    public partial class ZarzK : Form
    {
        public ZarzK()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tImie.Text) || string.IsNullOrEmpty(tNazwisko.Text) || string.IsNullOrEmpty(mtNumerTelefonu.Text) || string.IsNullOrEmpty(tPesel.Text) || string.IsNullOrEmpty(tEmail.Text))
            {
                MessageBox.Show("Proszę podać wszystkie dane!");
            }
            else
            {

                Regex wzorzec = new Regex("^\\d{11}$");
                if (wzorzec.IsMatch(tPesel.Text))
                {
                    Kontrahent kontr = new Kontrahent(tImie.Text, tNazwisko.Text, mtNumerTelefonu.Text, tPesel.Text, tEmail.Text);
                    ListaKontrahentow lista = new ListaKontrahentow(kontr);
                    lista.Dodaj(kontr);
                    MessageBox.Show("Dodano kontrahenta!");
                }
                else
                {
                    MessageBox.Show("Proszę podać poprawny numer PESEL!");
                }
            }
        }

        private void DodajXML_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tImie.Text) || string.IsNullOrEmpty(tNazwisko.Text) || string.IsNullOrEmpty(mtNumerTelefonu.Text) || string.IsNullOrEmpty(tPesel.Text) || string.IsNullOrEmpty(tEmail.Text))
            {
                MessageBox.Show("Proszę podać wszystkie dane!");
            }
            else
            {

                Regex wzorzec = new Regex("^\\d{11}$");
                if (wzorzec.IsMatch(tPesel.Text))
                {
                    Kontrahent kontr = new Kontrahent(tImie.Text, tNazwisko.Text, mtNumerTelefonu.Text, tPesel.Text, tEmail.Text);
                    kontr.SerializacjaXML();
                    ListaKontrahentow lista = new ListaKontrahentow(kontr);
                    lista.Dodaj(kontr);
                    MessageBox.Show("Dodano kontrahenta!");
                }
                else
                {
                    MessageBox.Show("Proszę podać poprawny numer PESEL!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tXML.Text))
            {
                MessageBox.Show("Proszę podać nazwę pliku!");
            }else
            {
                Kontrahent kontr = Kontrahent.DeserializacjaXML(tXML.Text);
                ListaKontrahentow lista = new ListaKontrahentow(kontr);
                lista.Dodaj(kontr);
                MessageBox.Show("Dodano kontrahenta!");
            }
        }
    }
}
