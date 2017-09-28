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
	public partial class CustomCellList : ContentPage
	{
		public CustomCellList ()
		{
			InitializeComponent ();
            myListView.ItemsSource = new List<ContactData>
            {
                new ContactData { Name = "Mitali", Status="Active", ImageUrl="http://lorempixel.com/100/100/sport/1"},
                new ContactData { Name = "Ai", Status="Absent", ImageUrl="http://lorempixel.com/100/100/sport/2"},
                new ContactData { Name = "Saeko", Status="Active", ImageUrl="http://lorempixel.com/100/100/sport/3"},
                new ContactData { Name = "Sena", Status="Active", ImageUrl="http://lorempixel.com/100/100/sport/4"}
            };
        }
	}
}