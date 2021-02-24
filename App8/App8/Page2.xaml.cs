using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            string x = await DisplayActionSheet("Odabir teksta", "Izlaz", "Homepage","Tekst 1", "Tekst 2", "Tekst 3");
            switch(x)
            {
                case "Tekst 1": poruka.Text = "Los Angeles Lakers je profesionalni košarkaški klub iz Los Angelesa, Kalifornije koji igra u NBA ligi."; break;
                case "Tekst 2": poruka.Text = "Lakersi vladaju kao NBA prvaci nakon pobjede nad Boston Celticsima u finalu 2010. godine, rezultatom 4 — 3. Lakersi imaju 16 titula prvaka NBA lige. Lakersi su najvrijedniji NBA klub prema magazinu Forbes, koji im je procijenio vrijednost od 643 milijuna dolara."; break;
                case "Tekst 3": poruka.Text = "Klub je osnovan 1947. godine kao Detroit Gems. Kasnije su počeli igrati u Minneapolisu, Minnesoti, nazivajući se Lakers, u čast nadimka države Zemlja sa 10,000 jezera. Lakersi su osvojili pet prvenstava u Minneapolisu gdje su pokrenuli Centra Georgea Mikana koji je na službenoj stranici NBA opisan kao prvi superstar. Nakon što su Lakersi upali u financijske probleme, preselili su se u Los Angeles 1959. godine."; break;
                case "Homepage": await Navigation.PushAsync(new Page1()); break;
            }

            

        }
    }
}