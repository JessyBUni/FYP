using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using detail_test.ViewModels;

namespace detail_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordPage : ContentPage
    {
        public LoginViewModel lm = new LoginViewModel();
        public PasswordPage()
        {
            //var lm = new LoginViewModel();  
            this.BindingContext = lm;  
            lm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent();

            Email.Completed += (object sender, EventArgs e) =>  
            {  
                Password.Focus();  
            };

            Password.Completed += (object sender, EventArgs e) =>  
            {  
                //vm.SubmitCommand.Execute(null);  
            };
        }

        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (lm.SubmitInfo(out int subLevel, out int progress))
            {
                var MainPage = (new MainPage(subLevel,progress));

                Application.Current.MainPage = MainPage;
                //await Navigation.PushModalAsync(MainPage);
            }


        }
    }
}
