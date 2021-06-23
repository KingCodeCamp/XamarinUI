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
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            p.Source = ImageSource.FromResource("Wave.Images.p2.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThirdPage());
        }

        private void skip_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}