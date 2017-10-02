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
    public partial class ActionSheetDemo : ContentPage
    {
        public ActionSheetDemo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("ContactMethod", "Cancel", "Delete", "Calle", "Message","Email","WhatsApp","Facebook");
            await DisplayAlert("Your Contact Method", result, "OK");

        }
    }
}