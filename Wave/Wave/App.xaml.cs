using System;
using Wave.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("GilroyBold.otf", Alias = "BoldFont")]
[assembly: ExportFont("GilroyLight.otf", Alias = "LightFont")]
[assembly: ExportFont("MediumMuseo.otf", Alias = "MediumFont")]
[assembly: ExportFont("LightMuseoSans.otf", Alias = "Light")]
[assembly: ExportFont("material.ttf", Alias = "Material")]
namespace Wave
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
