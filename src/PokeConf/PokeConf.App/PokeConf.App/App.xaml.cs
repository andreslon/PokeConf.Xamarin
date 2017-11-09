using System;
using PokeConf.App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PokeConf.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PokedexPage())
            {
                BarBackgroundColor = Color.FromHex("#A61407"),
                BarTextColor = Color.White,

            }; 
            MobileCenter.Start("android=bca54d0e-9034-4c3b-9112-e4e6622b9b68;",
                   typeof(Analytics), typeof(Crashes)); 

        }
    }
}