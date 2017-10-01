using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignments
{
    public partial class ListAssignments : ContentPage
    {
        private List<Search> myContacts;
        List<Search> getContact(string searchText = null)
        {
            myContacts = new List<Search>
            {
            new Search { Id = 1, Location = "West Hollywood, CA, United States", CheckIn = new DateTime(2016, 9, 1), CheckOut = new DateTime(2016, 11, 1) },
            new Search { Id = 2, Location = "Santa Monica, CA, United States", CheckIn = new DateTime(2016, 9, 1), CheckOut = new DateTime(2016, 11, 1) },
            };

            if (String.IsNullOrWhiteSpace(searchText))
            {
                return myContacts;
            }
            else
			{
				return myContacts.Where(c => c.Location.StartsWith(searchText)).ToList();
			}
        }

        public ListAssignments()
        {
            InitializeComponent();
            getContact();
            myListView.ItemsSource = myContacts;
			myListView.EndRefresh();
			myListView.IsRefreshing = false;
        }

		private void Delete_Click(object sender, EventArgs e)
		{
	    	var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as Search;
			myContacts.Remove(contact);
		}


		private void myListView_Refreshing(object sender, EventArgs e)
		{
			myListView.ItemsSource = getContact();
		}

		private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
		{
			myListView.ItemsSource = getContact(e.NewTextValue);
		}

	}
}
