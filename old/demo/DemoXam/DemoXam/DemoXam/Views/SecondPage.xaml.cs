using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoXam.Views
{
    public partial class SecondPage : ContentPage
    {
        
        public SecondPage(string parameter)
        {
            InitializeComponent();

            SecondLabel.Text = parameter;

			//1) Show simple list in string
			//MainListView.ItemsSource = new List<String>{
			//    "Pulkit", "sagar", "Aggarwal", "Paul"
			//};

			//Show list using POJO
			MainListView.ItemsSource = new List<Models.Persons>
			{
				new Models.Persons{
                    Name = "Pulkit",
                    Age = 20
                },
				new Models.Persons{
                    Name = "Sagar",
                    Age = 20
                },
				new Models.Persons{
                    Name = "Aggarwal",
                    Age = 20
                },
				new Models.Persons{
                    Name = "Paul",
                    Age = 20
				}
            };
        }
    }
}
