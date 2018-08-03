﻿using Android.App;
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
        public AnalogClock analogClock;
        public TextView text;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            TextView text = FindViewById<TextView>(Resource.Id.textview1);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Button sends user to the main activity of the application.
            ImageButton button1 = FindViewById<ImageButton>(Resource.Id.imgbutton1);
            button1.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            //Button sends user to the list activity of the application.
            ImageButton button2 = FindViewById<ImageButton>(Resource.Id.imgbutton2);
            button2.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(List));
                StartActivity(intent);
            };

            //Button sends user to the add activity of the application.
            ImageButton button3 = FindViewById<ImageButton>(Resource.Id.imgbutton3);
            button3.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Add));
                StartActivity(intent);
            };
        }
    }
}

