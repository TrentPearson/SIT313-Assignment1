using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Runtime;
using Android.Views;

namespace Assignment1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ImageButton button = FindViewById<ImageButton>(Resource.Id.imgbutton1);
            button.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Clock));
                StartActivity(intent);
            };
        }
    }
}

