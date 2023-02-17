using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
//szyfr_polialfabetyczny
    public partial class Form1 : Form
    {
        String staryTekst = String.Empty;
        String klucz = "";
        public Form1()
        {
            InitializeComponent();
        }

        bool tworzenieKlucza() {
            int indeks = 0;
            bool rezultat = false;

            if (tbKlucz.Text.Length > 0) { 
                while (klucz.Length < tbWiadomosc.Text.Length)
                {
                    klucz += tbKlucz.Text[indeks];
                    indeks++;
                    if (indeks == tbKlucz.Text.Length)
                    {
                        indeks = 0;
                    }
                } 
                  rezultat = true;
            }
          
            return rezultat;
        }
        String szyfrowanie(String s) {
            String zaszyfrowana= "";
            int c;

            if (tworzenieKlucza())
            {
                tworzenieKlucza();

                for (int i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    c = (c + klucz[i]) % 26;
                    zaszyfrowana += (char)(c + 65);

                }
            }
            return zaszyfrowana;
        }

        String deszyfrowanie(String s)
        {
            String kluczOdwrocony = "";         
            String odszyfrowana = "";
            int cKlucza;
            int c;

            if (tworzenieKlucza())
            {
                tworzenieKlucza();

                for (int i = 0; i < klucz.Length; i++)
                {
                    cKlucza = (65 + 26 - klucz[i]) % 26;
                    kluczOdwrocony += (char)(cKlucza + 65);

                }

                for (int i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    c = (c + kluczOdwrocony[i]) % 26;
                    odszyfrowana += (char)(c + 65);

                }
            }
            return odszyfrowana;
        }


        private void bSzyfruj_Click(object sender, EventArgs e)
        {
            tbZaszyfrowana.Text = szyfrowanie(tbWiadomosc.Text);

        }

        private void bOdszyfruj_Click(object sender, EventArgs e)
        {
            tbOdszyfrowana.Text = deszyfrowanie(tbZaszyfrowana.Text);
        }

        private void tbWiadomosc_TextChanged(object sender, EventArgs e)
        {
            if (tbWiadomosc.Text.All(chr => char.IsLetter(chr)))
            {
                staryTekst = tbWiadomosc.Text;
                tbWiadomosc.Text = staryTekst;

                tbWiadomosc.BackColor = Color.White;
                tbWiadomosc.ForeColor = Color.Black;
            }
            else
            {
                tbWiadomosc.Text = staryTekst;
                tbWiadomosc.BackColor = Color.Red;
                tbWiadomosc.ForeColor = Color.White;
                MessageBox.Show("Akceptowalne sa tylko litery.");
            }
            tbWiadomosc.SelectionStart = tbWiadomosc.Text.Length;
        }
    }
}