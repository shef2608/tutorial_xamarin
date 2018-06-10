using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMasterDetailPage.ViewModel;
using Xamarin.Forms;

namespace DemoMasterDetailPage
{
    public partial class MainPage : ContentPage 
    {
        public MainPage()
        {
            InitializeComponent();

			BindingContext = new HomeViewModel();
        }
    }
}
