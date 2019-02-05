using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using detail_test.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace detail_test
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
            MainPage = new PasswordPage();
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
