using System;

using TP.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            User u = await App.DataBase.getUserAsync(EntryEmail.Text);
            User etd = new User
            {
                UserName = EntryUserName.Text,
                Password = EntryPassword.Text,
                Email = EntryEmail.Text,
            };
            if (u == null)
            {
                await App.DataBase.addUserasync(etd);
                await  DisplayAlert("Success", " utilisateur ajouter", "ok");
              
                App.Current.MainPage = new NavigationPage(new LoginPage());
            }
            else
            
            {
                await DisplayAlert("Failed", "Email deja utiliser", "yes", "cancel");
            };


       
        }

      
    }
}