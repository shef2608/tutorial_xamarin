﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System.IO;
using Android.Content;

namespace DemoImage.Droid
{
	[Activity(Label = "DemoImage", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		// Field, property, and method for Picture Picker
		public static readonly int PickImageId = 1000;

		public TaskCompletionSource<Stream> PickImageTaskCompletionSource { set; get; }
		internal static MainActivity Instance { get; private set; }

		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			Instance = this;

			global::Xamarin.Forms.Forms.Init(this, bundle);
			LoadApplication(new App());
		}


		protected override void OnActivityResult(int requestCode, Result resultCode, Intent intent)
		{
			base.OnActivityResult(requestCode, resultCode, intent);
			if (requestCode == PickImageId)
			{
				if(intent != null){
					Android.Net.Uri uri = intent.Data;
                    Stream stream = ContentResolver.OpenInputStream(uri);

                    // Set the Stream as the completion of the Task
                    PickImageTaskCompletionSource.SetResult(stream);	
				}
			}
			else
            {
                PickImageTaskCompletionSource.SetResult(null);
            }
		}
	}
}

