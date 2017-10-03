using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickerDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableViewDemo : ContentPage
    {
        public TableViewDemo()
        {
            InitializeComponent();
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new ContactMethodPage();
            
            page.MyListView.ItemSelected += (source, args) =>
            {
                data.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };



            Navigation.PushAsync(new ContactMethodPage());
        }
    }
}