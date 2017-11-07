﻿using System;
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

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new PokedexPage();
            else 
                MainPage = new NavigationPage(new PokedexPage()); 
           

        }
    }
}