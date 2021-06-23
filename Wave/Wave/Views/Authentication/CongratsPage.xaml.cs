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
    public partial class CongratsPage : ContentPage
    {
        public CongratsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            img.Source = ImageSource.FromResource("Wave.Images.congrats.png");
        }

        private void home_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}