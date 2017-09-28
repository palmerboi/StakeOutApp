using StakeOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StakeOut
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Profile profile = new Profile();
               
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("hi", "you are a gay", "thanks");
        }

        public static implicit operator MainPage(StakeOutPINLogin v)
        {
            throw new NotImplementedException();
        }
    }
}
