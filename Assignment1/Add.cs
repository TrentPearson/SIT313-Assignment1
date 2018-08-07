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

            Mylistview = FindViewById<ListView>(Resource.Id.addlist);
            myitems = new List<string>();
            myitems.Add("Paris");
            myitems.Add("London");
            myitems.Add("Rome");
            myitems.Add("Hawaii");
            myitems.Add("Melbourne");
            myitems.Add("Tokyo");
            myitems.Add("New Zealand");
            ArrayAdapter<string> adpter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, myitems);

            Mylistview.Adapter = adpter;
            Mylistview.ItemClick += Mylistview_ItemClick;
        }

        private void Mylistview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (myitems[e.Position] == "Paris")
            {
                //DataStore.Instance.myitems.Add ("Paris");
                DataStore.Instance.Paris = true;
            }

            if (myitems[e.Position] == "Rome")
            {
                DataStore.Instance.Rome = true;
            }

            if (myitems[e.Position] == "London")
            {
                DataStore.Instance.London = true;
            }

            if (myitems[e.Position] == "Hawaii")
            {
                DataStore.Instance.Hawaii = true;
            }

            if (myitems[e.Position] == "Melbourne")
            {
                DataStore.Instance.Melbourne = true;
            }

            if (myitems[e.Position] == "Tokyo")
            {
                DataStore.Instance.Tokyo = true;
            }

            if (myitems[e.Position] == "New Zealand")
            {
                DataStore.Instance.New_Zealand = true;
            }

        }
    }
}