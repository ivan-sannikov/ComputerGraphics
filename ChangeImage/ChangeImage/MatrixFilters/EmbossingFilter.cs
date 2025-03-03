using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class EmbossingFilter : MatrixFilters
    {
        public EmbossingFilter()
        {
            kernel = new float[3, 3]
            {
                { 0, 1, 0 },
                { 1,0, -1 },
                { 0, -1, 0 }
            };
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)(sourceColor.R * 0.299 + sourceColor.G * 0.587 + sourceColor.B * 0.114);
            Color resultColor = Color.FromArgb(intensity, intensity, intensity);
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    resultR += resultColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += resultColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += resultColor.B * kernel[k + radiusX, l + radiusY];

                }
            }
            resultColor = Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
            return resultColor;
        }

     }
}
