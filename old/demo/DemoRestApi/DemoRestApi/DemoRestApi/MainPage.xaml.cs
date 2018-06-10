using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace DemoRestApi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

			getProducts();

        }

		private async void getProducts()
		{
			HttpClient httpClient = new HttpClient();

			var response = await httpClient.GetStringAsync("http://hyperamaapps.com/CRMApp/index.php/api/user/taskIDList");

			//var products = JsonConvert.DeserializeObject<Product>(response);
			//var products1 = products.details;
			//List<Detail> abc = new List<Detail>();
			//foreach(var item in products1){
			//	string TaskName = item.Task_Name.ToString();       
			//	string TaskId = item.Task_ID.ToString();
			//	abc.Add(new Detail(TaskId, TaskName));
			//}
            


			Console.WriteLine("abc");


			//productsListView.ItemsSource = products.details;
		}
	}
}
