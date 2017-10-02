using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignments
{
    public partial class CustomCellList : ContentPage
    {
        public CustomCellList()
        {
            InitializeComponent();
            myListView.ItemsSource = new List<Search>
			{
			new Search { Id = 1, Location = "West Hollywood, CA, United States", CheckIn = new DateTime(2016, 9, 1), CheckOut = new DateTime(2016, 11, 1) },
			new Search { Id = 2, Location = "Santa Monica, CA, United States", CheckIn = new DateTime(2016, 9, 1), CheckOut = new DateTime(2016, 11, 1) },
			};
        }
    }
}
