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
           
          //  var MyEntry = new Entry { IsPassword = true };
            var answer = await DisplayAlert("Confirm Stake?", "", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
            if(answer.Equals(true))
            {
                Stake stake = new Stake { s}
            }
        }


    }
}