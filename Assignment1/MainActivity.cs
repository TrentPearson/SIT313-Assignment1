using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;

namespace Assignment1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ImageButton button = FindViewById<ImageButton>(Resource.Id.imageButton1);
            button.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Clock));
                StartActivity(intent);
            };
        }
    }
}

