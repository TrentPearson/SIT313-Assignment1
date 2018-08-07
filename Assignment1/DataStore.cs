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
    public class DataStore
    {
        private static readonly DataStore instance = new DataStore();
        private DataStore() { }
        public static DataStore Instance
        {
            get { return instance; }
        }

        public string currentLocation { get; set; }
        public string currentTime { get; set; }
        public DateTime currentZoneTime { get; set; }
        public List<string> myitems { get; set; }
        //public ListView Mylistview { get; set; }

        public bool Paris { get; set; }
        public bool London { get; set; }
        public bool Rome { get; set; }
        public bool Hawaii { get; set; }
        public bool Melbourne { get; set; }
        public bool Tokyo { get; set; }
        public bool New_Zealand { get; set; }
    }
}