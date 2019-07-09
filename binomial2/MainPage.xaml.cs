using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace binomial2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            long x = 1;
            long y=1;
            x = Convert.ToInt64(Gora.Text);
            y = Convert.ToInt64(Dol.Text);

            if(y>x)
            {
                Wyswietl.Text = "E?#r*or";
            }
            else
            {
                long wynik = Skroc(x, y) / (Silnia(y));
                //long z = (Silnia(x)/(Silnia(y)*Silnia(x-y)));
                Wyswietl.Text = Convert.ToString(wynik);
            }
        }
        public long Silnia(long liczba)
        {
            if (liczba == 0)
            {
                return 1;
            }
            return (liczba * Silnia(liczba - 1));
        }
        public long Skroc(long x, long y)
        {
            long pom=1;
            long pomx = x;
            while(x>(pomx-y))
            {
                pom = pom * x;
                x -= 1;
            }
            return pom;
        }
    }
}
