using System;
using Android.Widget;
using DemoCheckInternetConnectivity.Droid.toastMessage;
using Xamarin.Forms;

[assembly:Dependency(typeof(ToastUtils))]
namespace DemoCheckInternetConnectivity.Droid.toastMessage
{
	public class ToastUtils : IToastMessage
	{
		public void longMessage(string message)
		{
			Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
		}

		public void shortMessage(string message)
		{
			Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
		}
	}
}
