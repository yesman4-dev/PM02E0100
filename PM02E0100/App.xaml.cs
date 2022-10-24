using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PM02E0100.Views;

namespace PM02E0100
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
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
