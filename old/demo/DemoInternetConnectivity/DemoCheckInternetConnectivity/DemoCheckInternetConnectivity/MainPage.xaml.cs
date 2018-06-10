using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace DemoCheckInternetConnectivity
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
			InitializeComponent();
        }

		private void Handle_Clicked(object sender, System.EventArgs e)
		{
			checkInternetConnection();
			var url = "http://" + urlEntry.Text;

			browser.Source = url;
		}

		private async void checkInternetConnection()
		{
			var response = false;

			if(CrossConnectivity.Current.IsConnected)
			{
				response = await DisplayAlert("Alert!","Internet is connected","Ok", "Cancel");
            }
			else
			{
				response = await DisplayAlert("Alert!", "No Internet Connection Found", "Ok", "Cancel");
			}

			if (response)
            {
                BackgroundColor = Color.Blue;

				var message = "This is the blue message";
				DependencyService.Get<IToastMessage>().longMessage(message);

            }
			else
            {
                BackgroundColor = Color.Red;

				var message = "This is the red message";
                DependencyService.Get<IToastMessage>().shortMessage(message);
            }
		}

		void Handle_Navigated(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
		{
			progressBar.IsVisible = false;
			progressBar.IsRunning = false;
		}

		void Handle_Navigating(object sender, Xamarin.Forms.WebNavigatingEventArgs e)
		{
			progressBar.IsVisible = true;
			progressBar.IsRunning = true;
		}
	}
}
