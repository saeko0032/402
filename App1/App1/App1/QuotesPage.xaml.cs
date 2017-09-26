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
        private int index = 0;
        private string[] messages = new string[]
        {
                "1. You cant blame gravity for falling in love",
                "2. Nothing is impossible",
                "3. Nothing is impossible",
                "4. Nothing is impossible",
                "5. Nothing is impossible"
        };
        public QuotesPage()
        {
        
            InitializeComponent();
            label2.Text = messages[index];
            string plat = Device.RuntimePlatform;
            if (plat.Equals("Android"))
            {
                Padding = new Thickness(20, 30, 20, 20);
            }
            if (plat.Equals("Windows"))
            {
                Padding = new Thickness(20, 40, 20, 20);
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            index++;
            if (index >= messages.Length)
            {
                index = 0;
            }

            label2.Text = messages[index];

        }
    }
}