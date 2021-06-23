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
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
            p.Source = ImageSource.FromResource("Wave.Images.p1.png");
        }

        private void next_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }

        private void skip_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}