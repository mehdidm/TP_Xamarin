using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navigation_Page : ContentPage
    {
        public Navigation_Page()
        {
            InitializeComponent();

            bntpush.Clicked += (sender, e) => { Navigation.PushAsync(new Navigation_Page()); };
            btnpop.Clicked += (sender, e) => { Navigation.PopAsync(); };
            bntpushm.Clicked += (sender, e) => { Navigation.PushModalAsync(new Navigation_Page()); };
            btnpopm.Clicked += (sender, e) => { Navigation.PopModalAsync(); };



        }

    }
}