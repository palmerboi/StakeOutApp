using StakeOut.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StakeOut
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StakeSaleForm : ContentPage
    {
        public StakeSaleForm()
        {
            InitializeComponent();
            btn.Clicked += Btn_Clicked;
        }



        async void Btn_Clicked(object sender, EventArgs e)
        {
           if(tournament.Text == null || venue.Text == null || date.Date == null || money.Text == null)
            {
               await DisplayAlert("Blank Fields", "Please fill out neccessary sections","Ok");
            }
            else
            {
                var answer = await DisplayAlert("Confirm Stake?", "", "Yes", "No");
                Debug.WriteLine("Answer: " + answer);
                if (answer.Equals(true))
                {
                    Stake stake = new Stake
                    {
                        tournament = tournament.Text,
                        venue = venue.Text,
                        date = date.Date,
                        markup = slider.Value,
                        stake = money.Text,
                        comments = comments.Text
                    };
                }
            }
           
        }


    }
}