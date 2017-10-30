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
                new Stake{ profile =  new Profile{name = "Red" , profilePicture = "http://lorempixel.com/100/100/people/2" }, stake = 5000, venue = "Wellington" },
                new Stake{ profile =  new Profile{name = "Borat" , profilePicture = "http://lorempixel.com/100/100/people/3" }, stake = 3000, venue = "Queenstown" },
                new Stake{ profile =  new Profile{name = "Shaq" , profilePicture = "http://lorempixel.com/100/100/people/4" }, stake = 3000, venue = "Hamilton" },
                new Stake{ profile =  new Profile{name = "Dwayne Johnson" , profilePicture = "http://lorempixel.com/100/100/people/5" }, stake = 3000, venue = "Christchurch" },
                new Stake{ profile =  new Profile{name = "Reuben" , profilePicture = "http://lorempixel.com/100/100/people/6" }, stake = 3000, venue = "Dunedin" },
            };
        }
        public StakeOutMarketplace()
        {
            InitializeComponent();
            stakeList.ItemsSource = GetStake();

        }


        private void ListView_Refreshing(object sender, EventArgs e)
        {
            stakeList.ItemsSource = GetStake();



            stakeList.EndRefresh();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var venues = venue.Items[venue.SelectedIndex];

            DisplayAlert("Selection", venues, "OK");

            List<Stake> L = GetStake();
            List<Stake> LL = new List<Stake>();
            foreach (var el in L)
            {

                if (el.venue == venues)
                {
                    // LL.Clear();
                    stakeList.ClearValue(ListView.ItemsSourceProperty);
                    LL.Add(el);
                    this.stakeList.ItemsSource = LL;

                }
                //if (el.venue == venues)
                //{
                //    LL.Clear();
                //    stakeList.ClearValue(ListView.ItemsSourceProperty);
                //    LL.Add(el);
                //    this.stakeList.ItemsSource = LL;
                //}
                //if (el.venue == venues)
                //{
                //    LL.Clear();
                //    stakeList.ClearValue(ListView.ItemsSourceProperty);
                //    LL.Add(el);
                //    this.stakeList.ItemsSource = LL;
                //}
            };


        }


    }

}