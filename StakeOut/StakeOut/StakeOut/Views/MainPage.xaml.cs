using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StakeOut.Views

{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Children.Add(new NavigationPage(new StakeOut.Views.ProfilePage()));
            this.Children.Add(new StakeOut.Views.StakeOutMarketplace());
        }
    }
}
