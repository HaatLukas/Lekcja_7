using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja7_Okienkowa_Sem1
{
    public partial class Zgadywanka : Form
    {
        int liczbaDoOdgadniecia = 0;
        int liczbaProb = 0;
        Random generator_liczb = new Random();

        public Zgadywanka()
        {
            InitializeComponent();

            //Wylosujemy liczby od 1 do 1000000
           liczbaDoOdgadniecia = generator_liczb.Next(1,100001);
            txt_licznikprob.Text = liczbaProb.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int podanaLiczba = int.Parse(txt_PodanaLiczba.Text);

            // Zwiekszamy liczbe prob liczbaProb=liczbaProb+1;
            liczbaProb++;
            txt_licznikprob.Text = liczbaProb.ToString();

            if (podanaLiczba == liczbaDoOdgadniecia)
            {
                MessageBox.Show("Wygrałeś!");
                // Wyłączenie aplikacji
                Application.Exit();
            }
            else
            {
                if (podanaLiczba > liczbaDoOdgadniecia)
                {
                    MessageBox.Show("Podana liczba jest zbyt duża");
                }
                else
                {
                    MessageBox.Show("Podana liczba jest zbyt mała");
                }
            }



        }
    }
}
