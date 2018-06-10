using System;
using DemoMasterDetailPage.Model;

namespace DemoMasterDetailPage.ViewModel
{
	public class HomeViewModel 
    {
		public TaskModel taskModel { get; set; }

		public HomeViewModel()
		{
			taskModel = new TaskModel
			{
				Title = "Pulkit Aggarwal",
				Duration = 2
			};
		}
	}
}
