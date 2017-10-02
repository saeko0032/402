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
    public partial class TabbedPageDemo : TabbedPage
    {
        public TabbedPageDemo()
        {
            InitializeComponent();
                listView.ItemsSource = new List<Activity>
                {
                    new Activity { UserId = 1, Name = "Jenny Daiby", Description="Your Facebook friend Jenny Daiby is on Instagram.", ImageUrl="http://lorempixel.com/100/100/people/1"},
                    new Activity { UserId = 2, Name = "Jonv", Description="Jonv started following you.", ImageUrl="http://lorempixel.com/100/100/people/2"},
                    new Activity { UserId = 3, Name = "Rachel Martin", Description="RachelMartin liked your photo.", ImageUrl="http://lorempixel.com/100/100/people/3"},
                    new Activity { UserId = 4, Name = "Nivan Jay",Description="Your Facebook friend Nivan Jay is on instagram.", ImageUrl="http://lorempixel.com/100/100/people/4"},
                    new Activity { UserId = 5, Name = "SanazZ",Description="SanazZ sent a photo posted by @brookeisep.", ImageUrl="http://lorempixel.com/100/100/people/5"},
                    new Activity { UserId = 6, Name = "NextLab",Description="NextLab started following you.", ImageUrl="http://lorempixel.com/100/100/people/6"},
                    new Activity { UserId = 7, Name = "Alex B",Description="Your facebook friend Alex B is on Instagram.", ImageUrl="http://lorempixel.com/100/100/people/7"},
                    new Activity { UserId = 8, Name = "Tara Chang",Description="Your Facebook friend Tara Chang is on Instagram.", ImageUrl="http://lorempixel.com/100/100/people/8"},
                    new Activity { UserId = 9, Name = "Tom K",Description="Your Facebook friend Tom K is on Instagram.", ImageUrl="http://lorempixel.com/100/100/people/9"}
                };

            this.Children.Add(new Profile());
        }

 

        //private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    var Contact = e.Item as Activity;
        //    await Navigation.PushAsync(new Details(Contact));
        //}

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Contact = e.SelectedItem as Activity;
            await Navigation.PushAsync(new Details(Contact));
        }
    }
}