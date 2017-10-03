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

    class ContactData
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    public partial class PickerDemo : ContentPage
    {
        private IList<ContactData> ContactMethod;

        public PickerDemo()
        {
            InitializeComponent();
            ContactMethod = GetContactMethod();
            foreach (var contactData in ContactMethod)
            {
                myPicker.Items.Add(contactData.Name);
            }
        }

        private IList<ContactData> GetContactMethod()
        {
            return new List<ContactData>
            {
               new ContactData { ID = 1, Name = "Call" },
                                    new ContactData { ID = 2, Name = "Message" },
                                    new ContactData { ID = 3, Name = "Email" },
                                    new ContactData { ID = 4, Name = "Whatsapp" }
            };
        }

            private void myPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = myPicker.Items[myPicker.SelectedIndex];
            DisplayAlert("Selection", result, "OK");
        }
    }
}