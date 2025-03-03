using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class HorizontalWaveFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX = x + (int)(20 * Math.Sin(2 * Math.PI * y / 60));
            int newY = y;
            newX = Clamp(newX, 0, sourceImage.Width - 1);
            newY = Clamp(newY, 0, sourceImage.Height - 1);
            return sourceImage.GetPixel(newX, newY);
        }
    }
}

