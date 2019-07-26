using ThePhoto.Views;
using Xamarin.Forms;

namespace ThePhoto
{
    public partial class App : Application
    {
        public const string ServiceId = "75e87ad6db41528330c2ed58eccd3a8f9d996587202d094ff3d7ce0be138d257";
        public App()
        {
            InitializeComponent();

            // MainPage = new RandomPhotoView();
         MainPage = new appShell();
            //MainPage = new AppShellTabs();
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
