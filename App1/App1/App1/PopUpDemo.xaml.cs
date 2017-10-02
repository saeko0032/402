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
	public partial class PopUpDemo : ContentPage
	{
		public PopUpDemo ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var Result = await DisplayAlert("Warning", "Are you sure?", "OK", "Cancel");

            if (Result)
            { 

                await DisplayAlert("Done", "You are done", "OK");
            }
            else
            {
                await DisplayAlert("Done", "You canceled", "OK");
            }
        }
    }
}