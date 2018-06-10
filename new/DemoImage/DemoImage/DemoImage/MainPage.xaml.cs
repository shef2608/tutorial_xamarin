
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoImage.gallery;
using Xamarin.Forms;

namespace DemoImage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

		private async void Handle_Clicked(object sender, System.EventArgs e)
		{
			pickPhoto.IsEnabled = false;
			Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

			if (stream != null)
			{
				var result = ImageSource.FromStream(() => stream);
				BackgroundColor = Color.Gray;

				galleryImage.Source = result;
			}


		}

		void addClicked(object sender, System.EventArgs e)
		{
			
		}
    }
}
