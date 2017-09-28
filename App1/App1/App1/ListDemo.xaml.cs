using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListDemo : ContentPage
	{
		public ListDemo ()
		{
			InitializeComponent ();
            /*
            var names = new List<string>
            {
               "Mitali",
               "Ai",
               "Sena",
               "Saeko",
               "Shinji",
               "Hannah"
            };
            myListView.ItemsSource = names;
            */
            myListView.ItemsSource = new List<ContactData>
            {
                new ContactData { Name = "Mitali", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new ContactData { Name = "Ai", Status="Absent", ImageUrl="http://lorempixel.com/100/100/people/2"},
                new ContactData { Name = "Saeko", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/3"},
                new ContactData { Name = "Sena", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/4"}
            };
		}
	}
}