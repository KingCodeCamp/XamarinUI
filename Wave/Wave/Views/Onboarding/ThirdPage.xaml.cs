using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Views.Authentication;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wave.Views.Onboarding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
            p.Source = ImageSource.FromResource("Wave.Images.p3.png");
        }

        private void start_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}