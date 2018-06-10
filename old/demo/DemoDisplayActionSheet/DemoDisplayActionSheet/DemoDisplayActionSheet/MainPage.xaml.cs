using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoDisplayActionSheet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

		private async void btn_clicked(Object sender, EventArgs eventArgs)
		{
			string options = await DisplayActionSheet(
			"Choose background color for the page",
				"ok",
				"cancel",
				"Navy",
                "Maroon",
				"Navy",
                "Maroon",
				"Navy",
				"Maroon","Navy",
				"Maroon","Navy",
				"Maroon","Navy",
				"Maroon","Navy",
                "Maroon",
			    "Pink");

			if (options == "Navy")
            {
				BackgroundColor = Color.Navy;
            }
			else if (options == "Maroon")
            {
				BackgroundColor = Color.Maroon;
            }
			else if (options == "Pink")
            {
                BackgroundColor = Color.Pink;
            }
			else if (options == "cancel")
            {
				
            }
			else if (options == "ok")
            {
                
            }
		}
	}
}
