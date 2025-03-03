using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class SharFilter: MatrixFilters
    {


        private static float[,] kernelX = new float[,]
        {
            { 3, 0, -3 },
            { 10, 0, -10 },
            { 3, 0, -3 }
        };

        private static float[,] kernelY = new float[,]
        {
            { 3, 10, 3 },
            {  0,  0,  0 },
            {  -3,  -10,  -3 }
        };
        public SharFilter() : base(kernelX) { }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernelX.GetLength(0) / 2;
            int radiusY = kernelX.GetLength(1) / 2;

            float resultRX = 0, resultGX = 0, resultBX = 0;
            float resultRY = 0, resultGY = 0, resultBY = 0;

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    resultRX += neighborColor.R * kernelX[k + radiusX, l + radiusY];
                    resultGX += neighborColor.G * kernelX[k + radiusX, l + radiusY];
                    resultBX += neighborColor.B * kernelX[k + radiusX, l + radiusY];
                }
            }
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    resultRY += neighborColor.R * kernelY[k + radiusX, l + radiusY];
                    resultGY += neighborColor.G * kernelY[k + radiusX, l + radiusY];
                    resultBY += neighborColor.B * kernelY[k + radiusX, l + radiusY];
                }
            }

            return Color.FromArgb(Clamp((int)Math.Sqrt(resultRX * resultRX + resultRY * resultRY), 0, 255),
                Clamp((int)Math.Sqrt(resultGX * resultGX + resultGY * resultGY), 0, 255),
                Clamp((int)Math.Sqrt(resultBX * resultBX + resultBY * resultBY), 0, 255));
        }
    }
}

