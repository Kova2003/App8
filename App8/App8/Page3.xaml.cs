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
    public partial class Page3 :CarouselPage
    {
        public Page3()
        {
            InitializeComponent();
            Lista.ItemsSource = new List<igraci.Class1>
            {
                new igraci.Class1 {ime="Marc Gasol", slika="pic5.jpg"},
                new igraci.Class1 {ime="Kyle Kuzma", slika="pic6.jpeg"},
                new igraci.Class1 {ime="Wesley Matthews", slika="pic7.jpg"},
                new igraci.Class1 {ime="K. Caldwell-Pope", slika="pic8.jpg"},
                new igraci.Class1 {ime="LeBron James", slika="pic9.jpg"}
            };
        }
    }
}