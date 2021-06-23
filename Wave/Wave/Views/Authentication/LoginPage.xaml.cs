using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wave.Views.Authentication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void forgotp_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResetPasswordPage());
        }

        private async void signup_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}