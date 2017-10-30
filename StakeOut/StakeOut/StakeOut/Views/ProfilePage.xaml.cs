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
        public ProfilePage()
        {
            Profile profile;


            InitializeComponent();

            profile = new Profile
            {
                name = "Borat Sagdiyev",
                description = "Veeerrry Niiiceee Poker Player!!!",
                hendonMobLink = "Borat Sagdiyev",
                twitterLink = "@Borat",
                profilePicture = "http://lorempixel.com/300/300/people"
            };

            Name.Text = profile.name;
            Description.Text = profile.description;
            ProfilePic.Source = profile.profilePicture;
            HendonLink.Text = profile.hendonMobLink;
            TwitterLink.Text = profile.twitterLink;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditProfilePageForm());
        }
    }
}