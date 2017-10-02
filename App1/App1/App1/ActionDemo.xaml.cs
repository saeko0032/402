using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActionDemo : ContentPage
	{
        private List<ContactData> myContacts;
        List<ContactData> getContact(string searchText = null)
        {
            myContacts = new List<ContactData>
                {
                new ContactData { Name = "Mitali", Status="Active", ImageUrl="http://lorempixel.com/100/100/sport/1"},
                new ContactData { Name = "Ai", Status="Absent", ImageUrl="http://lorempixel.com/100/100/sport/2"},
                new ContactData { Name = "Saeko", Status="Active", ImageUrl="http://lorempixel.com/100/100/sport/3"},
                new ContactData { Name = "Sena", Status="Active", ImageUrl="http://lorempixel.com/100/100/sport/4"}
                };
            if (String.IsNullOrWhiteSpace(searchText))
            {
                return myContacts;
            }
            else
            {
                return myContacts.Where(c => c.Name.StartsWith(searchText)).ToList();
            }
        }

    public ActionDemo ()
		{

			InitializeComponent ();
            getContact();

            myListView.ItemsSource = myContacts;
            myListView.EndRefresh();
            myListView.IsRefreshing = false;

        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as ContactData;
            DisplayAlert("Contact", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as ContactData;
	    // doesn't work for iOS11
            myContacts.Remove(contact);
            DisplayAlert("Contact", contact.Name, "OK");
        }

        private void MyListView_Refreshing(object sender, EventArgs e)
        {
            myListView.ItemsSource = getContact();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            myListView.ItemsSource = getContact(e.NewTextValue);
        }
    }
}
