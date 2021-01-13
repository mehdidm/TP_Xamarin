using System;


using TP.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            bnt1.Clicked += Button_Clicked_1;
        }

        

         private void Button_Clicked(object sender, EventArgs e)
        {
             App.Current.MainPage = new NavigationPage(new RegistrationPage());
        }

         public async void  Button_Clicked_1(object sender, EventArgs e)
        {
           
            User userr = new User

              
            {
                
                Password = EntryPassword.Text,
                Email = EntryEmail.Text,
            };

            User etd = await App.DataBase.getUserAsync(EntryEmail.Text);
            if (etd == null)
                
            await DisplayAlert("Error", "email incorrect", "cancel");
            else
            {
                User user = await App.DataBase.getUserAsync(EntryEmail.Text);
                if (user.Password == userr.Password)
                    App.Current.MainPage = new NavigationPage(new HomePage());
                else
                    
                await DisplayAlert("Error", "password incorrect", "cancel");
            }

       

        }
    } }