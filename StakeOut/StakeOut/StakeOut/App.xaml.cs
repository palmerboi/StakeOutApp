using StakeOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace StakeOut
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StakeOut.StakeOutPINLogin();
            Profile testPerson = new Profile
            {
                name = null,
                description = null,
                hendonMobLink = null,
                twitterLink = null,
                pin = 8888,
                profilePicture = null
            };

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
