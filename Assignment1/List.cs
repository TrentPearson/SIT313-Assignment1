using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Assignment1
{
    [Activity(Label = "List")]
    public class List : Activity
    {
        public List<string> myitems;
        public ListView Mylistview;
        public AnalogClock clock;
        //public TextView text;

        public String tokyo = "Tokyo";



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.list);


            Mylistview = FindViewById<ListView>(Resource.Id.listView1);
            myitems = new List<string>();
            myitems.Add("Melbourne");
            myitems.Add("Tokyo");
            myitems.Add("New Zealand");
            ArrayAdapter<string> adpter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, myitems);

            Mylistview.Adapter = adpter;
            Mylistview.ItemClick += Mylistview_ItemClick;        
    


            ImageButton button1 = FindViewById<ImageButton>(Resource.Id.imgbutton1);
            button1.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            ImageButton button2 = FindViewById<ImageButton>(Resource.Id.imgbutton2);
            button2.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(List));
                StartActivity(intent);
            };

            ImageButton button3 = FindViewById<ImageButton>(Resource.Id.imgbutton3);
            button3.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Add));
                StartActivity(intent);
            };
        }

        private void Mylistview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var utcTime = DateTime.UtcNow;
            //TextView text = FindViewById<TextView>(Resource.Id.textview1);
            

            if (myitems[e.Position] == "Melbourne")
            {
                //TextView text = FindViewById<TextView>(Resource.Id.textview1);
                //text.Text = "melbourne";

                //TextView text = new TextView(this);
                //text.Text = "Melbourne";



                var intent = new Intent(this, typeof(MainActivity));

                var analogClock = FindViewById<AnalogClock>(Resource.Id.analogClock1);
                TimeZoneInfo time = TimeZoneInfo.FindSystemTimeZoneById("Australia/Melbourne");
                DateTime zoneTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, time);

                StartActivity(intent);
            }
            if (myitems[e.Position] == "Tokyo")
            {                         

                var intent = new Intent(this, typeof(MainActivity));                
                StartActivity(intent);

                MainActivity main = new MainActivity();
                var analogClock = FindViewById<AnalogClock>(Resource.Id.analogClock1);
                TimeZoneInfo time = TimeZoneInfo.FindSystemTimeZoneById("Asia/Tokyo");
                DateTime zoneTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, time);

                TextView text = FindViewById<TextView>(Resource.Id.textview1);
                text.Text = "Tokyo";
            }
        }
    }
}