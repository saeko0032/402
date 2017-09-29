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
    public partial class Contacts : ContentPage
    {
        public Contacts()
        {
            InitializeComponent();
            listView.ItemsSource = new List<ContactData>
            {
                new ContactData { Name = "Mitali", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new ContactData { Name = "Ai", Status="Absent", ImageUrl="http://lorempixel.com/100/100/people/2"},
                new ContactData { Name = "Saeko", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/3"},
                new ContactData { Name = "Sena", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/4"}
            };
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Contact = e.SelectedItem as Activity;
            await Navigation.PushAsync(new Details(Contact));
        }
    }
}