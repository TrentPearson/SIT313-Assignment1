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
        public List<string> myitems = new List<string>();
        public ListView Mylistview;
        public TextView text;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.list);

            //Button sends user to the "MainActivity" activity of the application.
            ImageButton button1 = FindViewById<ImageButton>(Resource.Id.imgbutton1);
            button1.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            //Button sends user to the "List" activity of the application.
            ImageButton button2 = FindViewById<ImageButton>(Resource.Id.imgbutton2);
            button2.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(List));
                StartActivity(intent);
            };

            //Button sends user to the "Add" activity of the application.
            ImageButton button3 = FindViewById<ImageButton>(Resource.Id.imgbutton3);
            button3.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Add));
                StartActivity(intent);
            };

            //Defines location of the listview in question.
            Mylistview = FindViewById<ListView>(Resource.Id.listView1);

            //The bellow if statements state that, if the cooresponding namespace is selected in the "DataStore" class, then add that namespace to "myitems", whichis located in the "List" class.
            if(DataStore.Instance.Paris)
            {
                myitems.Add("Paris");
            }
            if (DataStore.Instance.Rome)
            {
                myitems.Add("Rome");
            }
            if (DataStore.Instance.London)
            {
                myitems.Add("London");
            }
            if (DataStore.Instance.Hawaii)
            {
                myitems.Add("Hawaii");
            }
            if (DataStore.Instance.Melbourne)
            {
                myitems.Add("Melbourne");
            }
            if (DataStore.Instance.Tokyo)
            {
                myitems.Add("Tokyo");
            }
            if (DataStore.Instance.New_Zealand)
            {
                myitems.Add("New Zealand");
            }

            //This statement states that if the length of characters within "myitems" are equal to 0, then the array adapter can allow the click event to occur.
            if (myitems.Count > 0)
            {
                ArrayAdapter<string> adpter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, myitems);

                Mylistview.Adapter = adpter;
                Mylistview.ItemClick += Mylistview_ItemClick;
            }
        }

        //This function tells the program that when a particular listview section is engaged, then the cooresponding 'if' statement can occur 
        private void Mylistview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //Define the UTC time for the different time zones.
            var utcTime = DateTime.UtcNow;
            
            //The following 'if' statements state that is they are selected, "currentLocation" values becomes that string value, along with setting the value of "currentTimeZone" to the cooresponding values, it then takes that user to the "MainActivity" class.
            if (myitems[e.Position] == "Melbourne")
            {
                DataStore.Instance.currentLocation = "Melbourne";

                var intent = new Intent(this, typeof(MainActivity));


                TimeZoneInfo time = TimeZoneInfo.FindSystemTimeZoneById("Australia/Melbourne");
                DateTime zoneTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, time);
                DataStore.Instance.currentZoneTime = zoneTime;

                StartActivity(intent);
            }
            if (myitems[e.Position] == "Tokyo")
            {
                DataStore.Instance.currentLocation = "Tokyo";

                TimeZoneInfo time = TimeZoneInfo.FindSystemTimeZoneById("Asia/Tokyo");
                DateTime zoneTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, time);
                DataStore.Instance.currentZoneTime = zoneTime;

                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            }
            if (myitems[e.Position] == "New Zealand")
            {
                DataStore.Instance.currentLocation = "New Zealand";

                TimeZoneInfo time = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
                DateTime zoneTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, time);
                DataStore.Instance.currentZoneTime = zoneTime;

                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            }
            if (myitems[e.Position] == "Hawaii")
            {
                DataStore.Instance.currentLocation = "Hawaii";

                TimeZoneInfo time = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Honolulu");
                DateTime zoneTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, time);
                DataStore.Instance.currentZoneTime = zoneTime;

                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            }
            if (myitems[e.Position] == "London")
            {
                DataStore.Instance.currentLocation = "London";

                TimeZoneInfo time = TimeZoneInfo.FindSystemTimeZoneById("Europe/London");
                DateTime zoneTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, time);
                DataStore.Instance.currentZoneTime = zoneTime;

                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            }
            if (myitems[e.Position] == "Rome")
            {
                DataStore.Instance.currentLocation = "Rome";

                TimeZoneInfo time = TimeZoneInfo.FindSystemTimeZoneById("Europe/Rome");
                DateTime zoneTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, time);
                DataStore.Instance.currentZoneTime = zoneTime;

                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            }
            if (myitems[e.Position] == "Paris")
            {
                DataStore.Instance.currentLocation = "Paris";

                TimeZoneInfo time = TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris");
                DateTime zoneTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, time);
                DataStore.Instance.currentZoneTime = zoneTime;

                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            }




        }
    }
}