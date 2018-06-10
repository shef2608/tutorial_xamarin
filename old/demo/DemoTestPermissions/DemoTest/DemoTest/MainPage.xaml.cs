﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Plugin.Media;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;

namespace DemoTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

		bool busy;
        async void ButtonPermission_OnClicked(object sender, EventArgs e)
        {
            if (busy)
                return;

            busy = true;
            ((Button)sender).IsEnabled = false;

            var status = PermissionStatus.Unknown;
            switch (((Button)sender).StyleId)
            {
                case "Calendar":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Calendar);
                    break;
                case "Camera":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
                    break;
                case "Contacts":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Contacts);
                    break;
                case "Microphone":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Microphone);
                    break;
                case "Geolocation":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
                    break;
                case "Phone":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Phone);
                    break;
                case "Photos":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Photos);
                    break;
                case "Reminders":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Reminders);
                    break;
                case "Sensors":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Sensors);
                    break;
                case "Sms":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Sms);
                    break;
                case "Storage":
                    status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
                    break;
                case "Settings":
                    CrossPermissions.Current.OpenAppSettings();
                    ((Button)sender).IsEnabled = true;
                    busy = false;
                    return;
            }

            await DisplayAlert("Pre - Results", status.ToString(), "OK");

            if (status != PermissionStatus.Granted)
            {
                switch (((Button)sender).StyleId)
                {
                    case "Calendar":
                        status = await Utils.CheckPermissions(Permission.Calendar);
                        break;
                    case "Camera":
                        status = await Utils.CheckPermissions(Permission.Camera);
                        break;
                    case "Contacts":
                        status = await Utils.CheckPermissions(Permission.Contacts);
                        break;
                    case "Geolocation":
                        status = await Utils.CheckPermissions(Permission.Location);
                        break;
                    case "Microphone":
                        status = await Utils.CheckPermissions(Permission.Microphone);
                        break;
                    case "Phone":
                        status = await Utils.CheckPermissions(Permission.Phone);
                        break;
                    case "Photos":
                        status = await Utils.CheckPermissions(Permission.Photos);
                        break;
                    case "Reminders":
                        status = await Utils.CheckPermissions(Permission.Reminders);
                        break;
                    case "Sensors":
                        status = await Utils.CheckPermissions(Permission.Sensors);
                        break;
                    case "Sms":
                        status = await Utils.CheckPermissions(Permission.Sms);
                        break;
                    case "Storage":
                        status = await Utils.CheckPermissions(Permission.Storage);
                        break;
                }

                await DisplayAlert("Results", status.ToString(), "OK");

            }

            busy = false;
            ((Button)sender).IsEnabled = true;
        }

        async void Button_OnClicked(object sender, EventArgs e)
        {
            if (busy)
                return;

            busy = true;
            ((Button)sender).IsEnabled = false;

            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await DisplayAlert("Need location", "Gunna need that location", "OK");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);
                    status = results[Permission.Location];
                }

                if (status == PermissionStatus.Granted)
                {
                    var results = await CrossGeolocator.Current.GetPositionAsync(TimeSpan.FromSeconds(10));
                    LabelGeolocation.Text = "Lat: " + results.Latitude + " Long: " + results.Longitude;
                }
                else if (status != PermissionStatus.Unknown)
                {
                    await DisplayAlert("Location Denied", "Can not continue, try again.", "OK");
                }
            }
            catch (Exception ex)
            {

                LabelGeolocation.Text = "Error: " + ex;
            }

            ((Button)sender).IsEnabled = true;
            busy = false;
        }
    }
}
