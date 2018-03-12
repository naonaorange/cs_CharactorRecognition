using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;
using OpenCvSharp.Text;

namespace CharacterRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            var img = new Mat(@"image.png");
            var gray = new Mat();

            Cv2.CvtColor(img, gray, ColorConversionCodes.BGR2GRAY);

            var ocr = OCRTesseract.Create("./tessdata", "eng");
            string text;
            Rect[] boxes;
            string[] words;
            float[] confidences;
            


            ocr.Run(gray, out text, out boxes, out words, out confidences);

            Console.WriteLine("text: " + text);
            for(int i = 0; i < boxes.Count(); i++)
            {
                Console.WriteLine("boxes: " + boxes[i]);
                Console.WriteLine("words: " + words[i]);
                Console.WriteLine("confidences: " + confidences[i]);
            }


            Cv2.ImShow("test", gray);
            Cv2.WaitKey();
        }
    }
}
