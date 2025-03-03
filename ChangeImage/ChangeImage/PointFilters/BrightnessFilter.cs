using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage.PointFilters
{
    class BrightnessFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(Clamp((int)(sourceColor.R + 60), 0, 255), Clamp((int)(sourceColor.G + 60), 0, 255), Clamp((int)(sourceColor.B + 60), 0, 255));
            return resultColor;
        }
    }
}
