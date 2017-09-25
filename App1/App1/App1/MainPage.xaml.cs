using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string plat = Device.RuntimePlatform;
            if (plat.Equals("iOS"))
            {
                Padding = new Thickness(0, 20, 0, 0);
            }
            else if (plat.Equals("Android"))
            {
                Padding = new Thickness(10, 20, 0, 0);
            }
            if (plat.Equals("Windows"))
            {
                Padding = new Thickness(10, 20, 30, 0);
            }
        }
    }
}
