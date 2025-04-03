using System.IO;
using System.Drawing;
//using System.Drawing.Drawing2D;
using System;

namespace CyberBot
{
    internal class logo_loco
    {
        public logo_loco()
        {

            ////get full location of project
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            //replacing bin/Debug 
            string new_location = full_location.Replace("bin\\Debug\\", "");

            //then combine the path 
            string full_path = Path.Combine(new_location, "logo.jpg");

            //time to use ascii

            //creating the bitmap instance
            Bitmap image = new Bitmap(full_path);
            // set the size 
            image = new Bitmap(image, new Size(80, 40));


            //nested loop
            for (int height = 0; height < image.Height; height++)
            {
                for (int width = 0; width < image.Width; width++)
                {
                    Color pixelColor = image.GetPixel(width, height);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char aasciiChar = gray > 200 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '@';
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.Write(aasciiChar);

                }
                Console.WriteLine();
            }

        }
    }
}