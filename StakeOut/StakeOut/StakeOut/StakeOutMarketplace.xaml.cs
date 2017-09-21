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
		public StakeOutMarketplace ()
		{
			InitializeComponent ();

           
            ListView.ItemsSource = new List<Profile>
            {
                new Profile{ Name = "bob", ProfilePicture = "http://lorempixel.com/100/100/people/1"},
                new Profile{ Name = "Red", ProfilePicture = "http://lorempixel.com/100/100/people/2"}
            };
		}
	}
}