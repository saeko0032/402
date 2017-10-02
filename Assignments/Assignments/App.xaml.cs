using Xamarin.Forms;

namespace Assignments
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // (2) MainPage = new AssignmentsImage();
            // (3) - (1) MainPage = new AbsoluteLayout1();
            // (3) - (2) MainPage = new StackLayout1();
            // (3) - (3) MainPage = new StackLayout2();
            // (3) - (4) MainPage = new GridLayout1();
            // (3) - (5) MainPage = new GridLayout2();
            MainPage = new ListAssignments();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
