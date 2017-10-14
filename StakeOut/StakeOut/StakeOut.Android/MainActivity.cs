using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using PayPal.Forms;
using PayPal.Forms.Abstractions;
using PayPal.Forms.Abstractions.Enum;
using Android.Content;

namespace StakeOut.Droid
{
    [Activity(Label = "StakeOut", Icon = "@drawable/sandwich", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            PayPalManagerImplementation.Manager.OnActivityResult(requestCode, resultCode, data);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            PayPalManagerImplementation.Manager.Destroy();
        }

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            //CrossPayPalManager.Init(new PayPalConfiguration(
            //        PayPalEnvironment.NoNetwork,
            //        "Your PayPal ID from Aa6OJkWTeZ2TfqZOytnZSDV7XVQ4vtuYmoRDUeDsLInxMjfPKMveLGZR1u4mxRIMQD9SxN_5xv0zhLPM"
            //        )
            //{
            //    //If you want to accept credit cards
            //    AcceptCreditCards = true,
            //    //Your business name
            //    MerchantName = "Test Store",
            //    //Your privacy policy Url
            //    MerchantPrivacyPolicyUri = "https://www.example.com/privacy",
            //    //Your user agreement Url
            //    MerchantUserAgreementUri = "https://www.example.com/legal",

            //    // OPTIONAL - ShippingAddressOption (Both, None, PayPal, Provided)
            //    ShippingAddressOption = ShippingAddressOption.Both,

            //    // OPTIONAL - Language: Default languege for PayPal Plug-In
            //    Language = "eng",

            //    // OPTIONAL - PhoneCountryCode: Default phone country code for PayPal Plug-In
            //    PhoneCountryCode = "52",
            //}
            //);
            ImageCircleRenderer.Init();
            LoadApplication(new App());
        }
    }
}

