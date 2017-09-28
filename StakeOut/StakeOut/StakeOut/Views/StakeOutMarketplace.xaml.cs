using StakeOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StakeOut.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StakeOutMarketplace : ContentPage
    {

        List<Stake> GetStake()
        {
            return new List<Stake>
            {
                new Stake{ profile =  new Profile{name = "Bob" , profilePicture = "http://lorempixel.com/100/100/people/1" }, stake = 5000, venue = "Auckland" },
                new Stake{ profile =  new Profile{name = "Red" , profilePicture = "http://lorempixel.com/100/100/people/2" }, stake = 5000, venue = "Wellington" }
            };
        }
        public StakeOutMarketplace()
        {
            InitializeComponent();
            ListView.ItemsSource = GetStake();

        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            ListView.ItemsSource = GetStake();
            ListView.EndRefresh();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var venues = venue.Items[venue.SelectedIndex];

            DisplayAlert("Selection", venues, "OK");
        }
    }
}