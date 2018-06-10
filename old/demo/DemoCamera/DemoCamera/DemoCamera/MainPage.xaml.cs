using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace DemoCamera
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void Handle_Clicked(object sender, EventArgs e)
		{
    			await CrossMedia.Current.Initialize();

    			if (!CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.Current.IsPickPhotoSupported)
    			{
    				await DisplayAlert("Alert", "Photo Capture and Pick image not supported", "ok");
    				return;
    			}
    			else
    			{
    				var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
    				{
					    Directory = "my_images",
                        SaveToAlbum = true,
                        //CompressionQuality = 75,
                        //CustomPhotoSize = 50,
                        //PhotoSize = PhotoSize.MaxWidthHeight,
                        //MaxWidthHeight = 2000,
                        //DefaultCamera = CameraDevice.Front
					    //PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
    					//Directory = "Images",
					    //Name = "test.jpg"     
    			    });

        			if (file == null)
        			{
    					return;
        				
        			}
        			else
        			{
        					await DisplayAlert("File Path", file.Path, "Ok");
        			}
				MyImage.Source = ImageSource.FromStream(() =>
				{
					var stream = file.GetStream();
					file.Dispose();
					return stream;
					
				});
			   }
		}
	}
}
