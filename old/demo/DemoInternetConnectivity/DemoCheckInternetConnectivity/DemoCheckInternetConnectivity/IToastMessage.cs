using System;
namespace DemoCheckInternetConnectivity
{
	public interface IToastMessage
    {
		void longMessage(string message);
		void shortMessage(string message);
    }
}
