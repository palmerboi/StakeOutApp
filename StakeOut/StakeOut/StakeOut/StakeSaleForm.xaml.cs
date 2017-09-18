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
    public partial class StakeSaleForm : ContentPage
    {
        public StakeSaleForm()
        {
            InitializeComponent();

            var layout = new RelativeLayout();
            Content = layout;

            ////var aquaBox = new BoxView { Color = Color.Aqua };
            //layout.Children.Add(aquaBox,
            //                            widthConstraint: Constraint.RelativeToParent(parent => parent.Width)
            //                            heightConstraint)
        }
    }
}