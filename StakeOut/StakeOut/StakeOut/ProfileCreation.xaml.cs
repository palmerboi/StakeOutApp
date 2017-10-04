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
    public partial class ProfileCreation : ContentPage
    {
        public ProfileCreation()
        {
            InitializeComponent();
            btn.Clicked += Btn_Clicked;
        }


        async void Btn_Clicked(object sender, EventArgs e)
        {
            if (profilePicture.Source == null || name.Text == null || email.Text == null || dob.Date == null || pin.Text == null)
            {
                await DisplayAlert("Blank Fields", "Please fill out neccessary sections", "Ok");


            }
            else
            {
                var answer = await DisplayAlert("Confirm Profile?", "", "Yes", "No");
                if (answer.Equals(true))
                {
                    Profile profile = new Profile
                    {
                        //  profilePicture = profilePicture.Source,
                        name = name.Text,
                        email = email.Text,
                        hendonMobLink = hendonMobLink.Text,
                        twitterLink = twitterLink.Text,
                        dob = dob.Date,
                        pin = pin.Text,
                        description = description.Text
                    };
                }
            }
        }
    }
}
