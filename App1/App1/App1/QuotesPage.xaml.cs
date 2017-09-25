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
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            string[] messages = {
                "1. You cant blame gravity for falling in love",
                "2. Nothing is impossible",
                "3. Nothing is impossible",
                "4. Nothing is impossible",
                "5. Nothing is impossible" };

            InitializeComponent();
            string plat = Device.RuntimePlatform;
            if (plat.Equals("Android"))
            {
                Padding = new Thickness(20, 30, 20, 20);
            }
            if (plat.Equals("Windows"))
            {
                Padding = new Thickness(20, 40, 20, 20);
            }

            if (slider1.Equals("16"))
            {
                label2.Text = messages[0];
            }
            else if (slider1.Equals("17"))
            {
                label2.Text = messages[1];
            }
            else if (slider1.Equals("50"))
            {
                label2.Text = messages[2];
            }
        }
    }
}