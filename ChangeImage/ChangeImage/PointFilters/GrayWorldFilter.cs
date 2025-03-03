using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage.PointFilters
{
    class GrayWorldFilter : Filters
    {
        private double avgR = 0, avgG = 0, avgB = 0;
        private double avgGray = 0;
        private bool averagesCalculated = false;
        public GrayWorldFilter() { }
        private void CalculateAverages(Bitmap sourceImage)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            int totalPixels = width * height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = sourceImage.GetPixel(x, y);
                    avgR += pixel.R;
                    avgG += pixel.G;
                    avgB += pixel.B;
                }
            }
            avgR /= totalPixels;
            avgG /= totalPixels;
            avgB /= totalPixels;
            avgGray = (avgR + avgG + avgB) / 3.0;
            averagesCalculated = true;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (!averagesCalculated)
            {
                CalculateAverages(sourceImage);
            }
            Color pixel = sourceImage.GetPixel(x, y);
            int newR = Clamp((int)(pixel.R * avgGray / avgR), 0, 255);
            int newG = Clamp((int)(pixel.G * avgGray / avgG), 0, 255);
            int newB = Clamp((int)(pixel.B * avgGray / avgB), 0, 255);
            return Color.FromArgb(newR, newG, newB);
        }
    }
}