using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class Operation
    {
        private int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
        internal Color ApplyErosion(Bitmap sourceImage, int x, int y, int elementRadius, int[,] structuralElement)
        {
            int minIntensity = 255;

            for (int i = -elementRadius; i <= elementRadius; i++)
            {
                for (int j = -elementRadius; j <= elementRadius; j++)
                {
                    if (structuralElement[i + elementRadius, j + elementRadius] == 1)
                    {
                        int neighborX = Clamp(x + j, 0, sourceImage.Width - 1);
                        int neighborY = Clamp(y + i, 0, sourceImage.Height - 1);

                        Color neighborColor = sourceImage.GetPixel(neighborX, neighborY);
                        int intensity = (int)(0.299 * neighborColor.R + 0.587 * neighborColor.G + 0.114 * neighborColor.B);

                        if (intensity < minIntensity)
                            minIntensity = intensity;
                    }
                }
            }

            return Color.FromArgb(minIntensity, minIntensity, minIntensity);
        }


        internal Color ApplyDilation(Bitmap sourceImage, int x, int y, int elementRadius, int[,] structuralElement)
        {
            int maxIntensity = 0;

            for (int i = -elementRadius; i <= elementRadius; i++)
            {
                for (int j = -elementRadius; j <= elementRadius; j++)
                {
                    if (structuralElement[i + elementRadius, j + elementRadius] == 1)
                    {
                        int neighborX = Clamp(x + j, 0, sourceImage.Width - 1);
                        int neighborY = Clamp(y + i, 0, sourceImage.Height - 1);

                        Color neighborColor = sourceImage.GetPixel(neighborX, neighborY);
                        int intensity = (int)(0.299 * neighborColor.R + 0.587 * neighborColor.G + 0.114 * neighborColor.B);

                        if (intensity > maxIntensity)
                            maxIntensity = intensity;
                    }
                }
            }

            return Color.FromArgb(maxIntensity, maxIntensity, maxIntensity);
        }
    }
}
