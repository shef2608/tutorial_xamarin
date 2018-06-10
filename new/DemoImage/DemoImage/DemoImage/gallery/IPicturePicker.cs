using System;
using System.IO;
using System.Threading.Tasks;

namespace DemoImage.gallery
{
    public interface IPicturePicker
    {
		Task<Stream> GetImageStreamAsync();
    }
}
