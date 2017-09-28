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
	public partial class ProfilePage : ContentPage
	{
        Profile profile;

		public ProfilePage ()
		{
			InitializeComponent ();

            profile = new Profile { name = "Borat Sagdiyev",
                                    description = "Veeerrry Niiiceee Poker Player!!!",
                                    hendonMobLink = "Borat Sagdiyev",
                                    twitterLink = "@Borat",
                                    profilePicture = "http://lorempixel.com/100/100/people/1"};
		}
	}
}