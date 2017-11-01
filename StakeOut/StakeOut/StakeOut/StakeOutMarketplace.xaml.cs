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
            //temperary data base holding a some profiles 
           return new List<Stake>
            {
                new Stake{ profile =  new Profile{Name = "Bob" , ProfilePicture = "http://lorempixel.com/100/100/people/1" }, stake = 5000, venue = "Auckland" },
                new Stake{ profile =  new Profile{Name = "Red" , ProfilePicture = "http://lorempixel.com/100/100/people/2" }, stake = 5000, venue = "Wellington" },
                new Stake{ profile =  new Profile{Name = "Red" , ProfilePicture = "http://lorempixel.com/100/100/people/2" }, stake = 100, venue = "Wellington" },
                new Stake{ profile =  new Profile{Name = "Red" , ProfilePicture = "http://lorempixel.com/100/100/people/2" }, stake = 3000, venue = "Wellington" },
                new Stake{ profile =  new Profile{Name = "Borat" , ProfilePicture = "http://lorempixel.com/100/100/people/3" }, stake = 3000, venue = "Queenstown" },
                new Stake{ profile =  new Profile{Name = "Shaq" , ProfilePicture = "http://lorempixel.com/100/100/people/4" }, stake = 3000, venue = "Hamilton" },
                new Stake{ profile =  new Profile{Name = "Dyane Jonson" , ProfilePicture = "http://lorempixel.com/100/100/people/5" }, stake = 3000, venue = "Christchurch" },
                new Stake{ profile =  new Profile{Name = "Ruben" , ProfilePicture = "http://lorempixel.com/100/100/people/6" }, stake = 3000, venue = "Dunedin" },
                new Stake{ profile =  new Profile{Name = "Bob" , ProfilePicture = "http://lorempixel.com/100/100/people/1" }, stake = 5000, venue = "Auckland" },
                new Stake{ profile =  new Profile{Name = "Red" , ProfilePicture = "http://lorempixel.com/100/100/people/2" }, stake = 5000, venue = "Wellington" },
                new Stake{ profile =  new Profile{Name = "Red" , ProfilePicture = "http://lorempixel.com/100/100/people/2" }, stake = 100, venue = "Wellington" },
                new Stake{ profile =  new Profile{Name = "Red" , ProfilePicture = "http://lorempixel.com/100/100/people/2" }, stake = 3000, venue = "Wellington" },
                new Stake{ profile =  new Profile{Name = "Borat" , ProfilePicture = "http://lorempixel.com/100/100/people/3" }, stake = 3000, venue = "Queenstown" },
                new Stake{ profile =  new Profile{Name = "Shaq" , ProfilePicture = "http://lorempixel.com/100/100/people/4" }, stake = 3000, venue = "Hamilton" },
                new Stake{ profile =  new Profile{Name = "Dyane Jonson" , ProfilePicture = "http://lorempixel.com/100/100/people/5" }, stake = 3000, venue = "Christchurch" },
                new Stake{ profile =  new Profile{Name = "Ruben" , ProfilePicture = "http://lorempixel.com/100/100/people/6" }, stake = 3000, venue = "Dunedin" }

            };
        }
        //inislised the list market veiw
        public StakeOutMarketplace ()
		{
			InitializeComponent ();
            stakeList.ItemsSource = GetStake();

        }

        //refreshes the list  
        private void ListView_Refreshing(object sender, EventArgs e)
        {
            stakeList.ItemsSource = GetStake();
            stakeList.EndRefresh();
        }
        //picker holding the names of the venuse that alows for sorting
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
                   
                    stakeList.ClearValue(ListView.ItemsSourceProperty);
                    LL.Add(el);
                    this.stakeList.ItemsSource = LL;

                }
               
            };


        }

        
    }
        
}