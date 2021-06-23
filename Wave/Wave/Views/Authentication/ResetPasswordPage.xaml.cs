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
    public partial class ResetPasswordPage : ContentPage
    {
        public ResetPasswordPage()
        {
            InitializeComponent();
        }

        private async void confirmEmail_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckMailPage());
        }

        private async void signin_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}