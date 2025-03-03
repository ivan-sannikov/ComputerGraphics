using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class LinGistFilter : Filters
    {
        private int minIntensivity = 255;
        private int maxIntensivity = 0;
        private bool isSearchMinMax = false;

        public LinGistFilter() {
        }
        private void searchMinMaxIntensivity(Bitmap sourceImage)
        {
            
            for(int y = 0; y< sourceImage.Height; y++)
            {
                for(int x = 0; x< sourceImage.Width; x++) {
                    Color pixel = sourceImage.GetPixel(x, y);
                    int intensivity = (int)(0.299*pixel.R+0.587*pixel.G+0.114*pixel.B);
                    if(intensivity < minIntensivity)
                    {
                        minIntensivity = intensivity;
                    }
                    if(intensivity > maxIntensivity) {
                        maxIntensivity = intensivity;
                    }
                }
            }
            isSearchMinMax = true;
        }
        private int LinSearch(int value, int min, int max)
        {
            if(min == max)
            {
                return value;
            }
            return Clamp((int)((value - min)*(255-0)/(max-min)), 0, 255);
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (!isSearchMinMax)
            {
                searchMinMaxIntensivity(sourceImage);
            }
            Color pixel = sourceImage.GetPixel(x,y);
            return Color.FromArgb(LinSearch(pixel.R, minIntensivity, maxIntensivity),
                LinSearch(pixel.G, minIntensivity, maxIntensivity),
                LinSearch(pixel.B, minIntensivity, maxIntensivity));
        }
    }
}
