using System;
namespace DemoRestApi
{
    public class Detail
    {
		public string Task_ID { get; set; }
        public string Task_Name { get; set; }


		public Detail(string TaskId, string TaskName){
			this.Task_ID = TaskId;
			this.Task_Name = TaskName;
		}
    }
}
