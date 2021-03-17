using System;
using UtfUnknown;

namespace TestNugget
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../file/test.txt";

            DetectionResult result = CharsetDetector.DetectFromFile(path);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
