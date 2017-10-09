using StakeOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StakeOut
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StakeOutMarketplace : ContentPage

        
	{
        List<Stake> GetStake()
        {
           return new List<Stake>
            {
                new Stake{ profile =  new Profile{Name = "Bob" , ProfilePicture = "http://lorempixel.com/100/100/people/1" }, stake = 5000, venue = "Auckland" },
                new Stake{ profile =  new Profile{Name = "Red" , ProfilePicture = "http://lorempixel.com/100/100/people/2" }, stake = 5000, venue = "Wellington" }
            };
        }
        public StakeOutMarketplace ()
		{
			InitializeComponent ();
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
                    LL.Clear();
                    stakeList.ClearValue(ListView.ItemsSourceProperty);
                    LL.Add(el);
                    this.stakeList.ItemsSource = LL;

                }
                if (el.venue == venues)
                {
                    LL.Clear();
                    stakeList.ClearValue(ListView.ItemsSourceProperty);
                    LL.Add(el);
                    this.stakeList.ItemsSource = LL;
                }
                if (el.venue == venues)
                {
                    LL.Clear();
                    stakeList.ClearValue(ListView.ItemsSourceProperty);
                    LL.Add(el);
                    this.stakeList.ItemsSource = LL;
                }
            };


        }

        
    }
        
}