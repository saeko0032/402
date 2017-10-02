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
	public partial class EditorDemo : ContentPage
	{
		public EditorDemo ()
		{
			InitializeComponent ();
		}
        
        private void Entry_TextChanged(Object sender, TextChangedEventArgs e)
        {
            myLabel.Text = e.NewTextValue;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            myLabel.Text = "Completed";
        }
    }
}