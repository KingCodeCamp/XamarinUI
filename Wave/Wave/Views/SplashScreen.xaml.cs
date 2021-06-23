using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Views.Onboarding;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wave.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
            img.Source = ImageSource.FromResource("Wave.Images.splash.png");
           
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            img.Opacity = 0;
            await Task.WhenAny<bool>
            (
                img.FadeTo(1, 1000)
            );
            await Task.WhenAny<bool>
            (
                img.RotateTo(-DeviceDisplay.MainDisplayInfo.Width, 0, Easing.BounceOut)
            );
            App.Current.MainPage = new NavigationPage(new FirstPage());
            
        }
    }
}