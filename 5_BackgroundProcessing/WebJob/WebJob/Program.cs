using Microsoft.WindowsAzure.Jobs;
using nQuant;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            JobHost host = new JobHost();
            host.RunAndBlock();
        }

        public static void SquishNewlyUploadedPNGs(
            [BlobInput("input/{name}")] Stream input,
            [BlobOutput("output/{name}")] Stream output)
        {
            var quantizer = new WuQuantizer();
            using (var bitmap = new Bitmap(input))
            {
                using (var quantized = quantizer.QuantizeImage(bitmap))
                {
                    quantized.Save(output, ImageFormat.Png);
                }
            }

        }
    }
}