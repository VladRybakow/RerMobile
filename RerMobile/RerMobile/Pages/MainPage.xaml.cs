using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RerMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void ToModalPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisPage());
        }
        private async void ToNextPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProjectPage());
        }
    }
}
