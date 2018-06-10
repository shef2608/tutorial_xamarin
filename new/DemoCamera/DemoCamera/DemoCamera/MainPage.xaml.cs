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
		string imageName = null;
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
				//1) capturePhoto();
				getGalleryPhoto();

			}
		}

		private async void getGalleryPhoto()
		{
			var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
            {
                //Directory = "my_images",
                //SaveToAlbum = true,
                //CompressionQuality = 75,
                //CustomPhotoSize = 50,
				PhotoSize = PhotoSize.Small
                //MaxWidthHeight = 2000,
                //DefaultCamera = CameraDevice.Front
                //PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
                //Directory = "Images",
                //Name = "test.jpg"     

                //imageName = Directory
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

		private async void capturePhoto()
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

                //imageName = Directory
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
	} }
