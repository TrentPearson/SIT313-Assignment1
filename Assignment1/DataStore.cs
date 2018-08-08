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

        //Finds the location of the timezome from the "List" class, and adds to a textview in the "MainActivity" class. 
        public string currentLocation { get; set; }
        //Finds the time zone of the cooresponding location from the "List" class, and adds to a textview in the "MainActivity" class. 
        public string currentTime { get; set; }
        public DateTime currentZoneTime { get; set; }
        //The list array that holds the location and time zone information of all listviews, and sends them to the "MainActivity" class.
        public List<string> myitems { get; set; }

        //The following are the bools for each of the listview items that can be taken from the "Add" class, and added to the "List" class.
        public bool Paris { get; set; }
        public bool London { get; set; }
        public bool Rome { get; set; }
        public bool Hawaii { get; set; }
        public bool Melbourne { get; set; }
        public bool Tokyo { get; set; }
        public bool New_Zealand { get; set; }
    }
}