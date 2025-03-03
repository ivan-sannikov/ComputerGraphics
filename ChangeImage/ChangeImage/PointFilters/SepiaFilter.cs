using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class SepiaFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)(sourceColor.R * 0.299 + sourceColor.G * 0.587 + sourceColor.B * 0.114);
            Color resultColor = Color.FromArgb(Clamp((int)(intensity + 2 * 35), 0, 255), Clamp((int)(intensity + 0.5 * 35), 0, 255), Clamp((int)(intensity - 1 * 35), 0, 255));
            return resultColor;
        }
    }
}
