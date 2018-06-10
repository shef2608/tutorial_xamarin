using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoXam.Views
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button_clicked(object sender, EventArgs e){
            string text = MainEntry.Text;

            MainLabel.Text = "Hello " + text;
        }

        //This method is to go from one activity to another activity
        private async void Handle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage(MainLabel.Text));
        }
    }
}
