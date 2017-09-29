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
                    new Activity { UserId = 1, Description="Your Facebook friend Jenny Daiby is on Instagram.", ImageUrl="http://lorempixel.com/100/100/people/1"},
                    new Activity { UserId = 2, Description="Jonv started following you.", ImageUrl="http://lorempixel.com/100/100/people/2"},
                    new Activity { UserId = 3, Description="RachelMartin liked your photo.", ImageUrl="http://lorempixel.com/100/100/people/3"},
                    new Activity { UserId = 4, Description="Your Facebook friend Nivan Jay is on instagram.", ImageUrl="http://lorempixel.com/100/100/people/4"},
                    new Activity { UserId = 5, Description="SanazZ sent a photo posted by @brookeisep.", ImageUrl="http://lorempixel.com/100/100/people/5"},
                    new Activity { UserId = 6, Description="NextLab started following you.", ImageUrl="http://lorempixel.com/100/100/people/6"},
                    new Activity { UserId = 7, Description="Your facebook friend Alex B is on Instagram.", ImageUrl="http://lorempixel.com/100/100/people/7"},
                    new Activity { UserId = 8, Description="Your Facebook friend Tara Chang is on Instagram.", ImageUrl="http://lorempixel.com/100/100/people/8"},
                    new Activity { UserId = 9, Description="Your Facebook friend Tom K is on Instagram.", ImageUrl="http://lorempixel.com/100/100/people/9"}
                };

            this.Children.Add(new Profile());
        }

        private async void ListView_Select(object sender, SelectedItemChangedEventArgs e)
        {
            var Contact = e.SelectedItem as Activity;
            await Navigation.PushAsync(new Details(Contact));
        }
    }
}