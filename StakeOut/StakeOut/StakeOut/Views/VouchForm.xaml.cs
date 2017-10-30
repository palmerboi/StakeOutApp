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
	public partial class VouchForm : ContentPage
	{
		public VouchForm()
		{
			InitializeComponent ();
            //profileList.ItemsSource = GetProfile();
        }

        /*List<Profile> GetStake()
        {
            return new List<Profile>
            {
                OtherProfile2 =  new Profile{name = "Red" , profilePicture = "http://lorempixel.com/100/100/people/2" },
                OtherProfile3 =  new Profile{name = "Borat" , profilePicture = "http://lorempixel.com/100/100/people/3" },
                OtherProfile4 =  new Profile{name = "Shaq" , profilePicture = "http://lorempixel.com/100/100/people/4" },
                OtherProfile5 =  new Profile{name = "Dwayne Johnson" , profilePicture = "http://lorempixel.com/100/100/people/5" },
                OtherProfile6 =  new Profile{name = "Reuben" , profilePicture = "http://lorempixel.com/100/100/people/6" },
            };
        }
        */

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OtherProfilePage());
        }
    }
}