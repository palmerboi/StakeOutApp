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
    public partial class PinPage : ContentPage
    {
        int failAttempts = 0;

        public PinPage()
        {
            InitializeComponent();
        }

        private void PINEnter_Clicked(object sender, EventArgs e)
        {
            if (xNamePin.Text == null)
            {
                DisplayAlert("", "Please enter a PIN Code before pressing the Enter button", "Ok");
            }
            else
            {
                int pin = Int32.Parse(xNamePin.Text);
                if (pin == 8888)
                {
                    DisplayAlert("Success!", "You have been successfully logged in", "Log in");
                }
                else if (failAttempts >= 3)
                {
                    DisplayAlert("Failed!", "You have had 3 failed attempts. Please try again next time!", "Ok...");
                }
                else
                {
                    DisplayAlert("Wrong PIN!", "You have entered the wrong PIN. Please try again", "Ok");
                    ++failAttempts;
                }
            }
        }
    }
}