using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoSeekBarSlider
{
    public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();

			setProgressBar();
        }

		//1) Slider
		//void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
		// {
 			//mainLabel.Text = mainSlider.Value.ToString();
        //}

		//2) Date Picker
		//void Handle_DateSelected(object sender, DateChangedEventArgs e)
		//{
		//	//mainLabel.Text = e.NewDate.Day.ToString();
		//	//mainLabel.Text = e.NewDate.Month.ToString();
		//	mainLabel.Text = e.NewDate.Year.ToString();

		//}

		//3) Switch button
		//void Handle_Toggled(object sender, ToggledEventArgs e)
		//{
		//	bool isToggled = e.Value;
		//	mainLabel.Text = isToggled.ToString();
		//}

		//4) Progress Bar
		public void setProgressBar(){
			//mainProgressBar.ProgressTo(0.8);
		}
    }
}
