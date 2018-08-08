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
    [Activity(Label = "Add")]
    public class Add : Activity
    {
        public List<string> myitems;
        public ListView Mylistview;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.add);

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

            //Define the location of the listview in question.
            Mylistview = FindViewById<ListView>(Resource.Id.addlist);

            //Adds the following namespaces into "myitems" of the listview
            myitems = new List<string>();
            myitems.Add("Paris");
            myitems.Add("London");
            myitems.Add("Rome");
            myitems.Add("Hawaii");
            myitems.Add("Melbourne");
            myitems.Add("Tokyo");
            myitems.Add("New Zealand");

            //Creates an array adapter for the listview, and defines the click event.
            ArrayAdapter<string> adpter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, myitems);
            Mylistview.Adapter = adpter;
            Mylistview.ItemClick += Mylistview_ItemClick;
        }

        //The following 'if' statements add each of the cooresponding strings to the listview in the "List" class by telling the bool that it is now true, and can add itself to the listview.
        //The program then takes the user to the "List" activity when the new list item can be seen.
        private void Mylistview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (myitems[e.Position] == "Paris")
            {
                DataStore.Instance.Paris = true;
                var intent = new Intent(this, typeof(List));
                StartActivity(intent);
            }

            if (myitems[e.Position] == "Rome")
            {
                DataStore.Instance.Rome = true;
                var intent = new Intent(this, typeof(List));
                StartActivity(intent);
            }

            if (myitems[e.Position] == "London")
            {
                DataStore.Instance.London = true;
                var intent = new Intent(this, typeof(List));
                StartActivity(intent);
            }

            if (myitems[e.Position] == "Hawaii")
            {
                DataStore.Instance.Hawaii = true;
                var intent = new Intent(this, typeof(List));
                StartActivity(intent);
            }

            if (myitems[e.Position] == "Melbourne")
            {
                DataStore.Instance.Melbourne = true;
                var intent = new Intent(this, typeof(List));
                StartActivity(intent);
            }

            if (myitems[e.Position] == "Tokyo")
            {
                DataStore.Instance.Tokyo = true;
                var intent = new Intent(this, typeof(List));
                StartActivity(intent);
            }

            if (myitems[e.Position] == "New Zealand")
            {
                DataStore.Instance.New_Zealand = true;
                var intent = new Intent(this, typeof(List));
                StartActivity(intent);
            }

        }
    }
}