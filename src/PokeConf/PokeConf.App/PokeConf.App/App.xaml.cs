using System;
using PokeConf.App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
           

        }
    }
}