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
	public partial class OtherProfilePage : ContentPage
	{

        public OtherProfilePage ()
		{
            Profile otherProfile;

			InitializeComponent();

            Random random = new Random();
            int randomID = random.Next();
            string textID = randomID.ToString();

            otherProfile =  new Profile{Id = textID, name = "Bob", description = "Another StakeOut Player", hendonMobLink = "Bob", twitterLink = "@Bob", profilePicture = "http://lorempixel.com/300/300/people/1"};

            Name.Text = otherProfile.name;
            Description.Text = otherProfile.description;
            ProfilePic.Source = otherProfile.profilePicture;
            HendonLink.Text = otherProfile.hendonMobLink;
            TwitterLink.Text = otherProfile.twitterLink;
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VouchForm());
        }
    }
}