using TP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void MasterDetailPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MasterPage());
        }
        private void TabbedPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPageD());
        }
        private void CarouselPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarouselPages());
        }
        private void NavigationPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Navigation_Page());
        }
    }
}