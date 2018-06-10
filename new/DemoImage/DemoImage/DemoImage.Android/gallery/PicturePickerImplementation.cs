using System;
using System.IO;
using System.Threading.Tasks;
using Android.Content;
using DemoImage.Droid.gallery;
using DemoImage.gallery;
using Xamarin.Forms;

[assembly: Dependency(typeof(PicturePickerImplementation))]
namespace DemoImage.Droid.gallery
{
	public class PicturePickerImplementation : IPicturePicker
	{
		public Task<Stream> GetImageStreamAsync()
		{
			// Define the Intent for getting images
			Intent intent = new Intent();
            intent.SetType("image/*");
			//intent.PutExtra(Intent.ExtraAllowMultiple, true);
            intent.SetAction(Intent.ActionGetContent);

			// Start the picture-picker activity (resumes in MainActivity.cs)
			MainActivity.Instance.StartActivityForResult(
                Intent.CreateChooser(intent, "Select Picture"),
                MainActivity.PickImageId);

			// Save the TaskCompletionSource object as a MainActivity property
            MainActivity.Instance.PickImageTaskCompletionSource = new TaskCompletionSource<Stream>();

			// Return Task object
            return MainActivity.Instance.PickImageTaskCompletionSource.Task;

		}
	}
}
