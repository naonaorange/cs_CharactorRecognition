using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;

namespace CharacterRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            var img = new Mat(@"image.png");
            Cv2.ImShow("test", img);
            Cv2.WaitKey();
        }
    }
}
