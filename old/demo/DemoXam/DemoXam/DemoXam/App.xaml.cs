using Xamarin.Forms;

namespace DemoXam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //1) Go from one Activity to another activity.
            //MainPage = new NavigationPage(new Views.StartPage());

            //2) Tabbed Page
            MainPage = new TabbedPage
            {
                Children = {
                    new Views.StartPage(),
                    new Views.SecondPage("Hello Sec")
                }
            };

            //3) View Pager
            //MainPage = new CarouselPage
            //{
            //    Children = {
            //        new Views.StartPage(),
            //        new Views.SecondPage("Hello Sec")
            //    }
            //};
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
