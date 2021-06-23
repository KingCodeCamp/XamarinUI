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
    public partial class CheckMailPage : ContentPage
    {
        public CheckMailPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            img.Source = ImageSource.FromResource("Wave.Images.checkmail.png");
        }

        private async void enterPassword_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangePasswordPage());
        }
    }
}