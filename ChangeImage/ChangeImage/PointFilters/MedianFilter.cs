using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class MedianFilter : Filters
    {
        private int radius = 1;
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            List<int> redV = new List<int>();
            List<int> greenV = new List<int>();
            List<int> blueV = new List<int>();
            for(int i = -radius; i <= radius; i++)
            {
                for(int j = -radius; j <= radius; j++)
                {
                    int idx = Clamp(x + j,0,sourceImage.Width-1);
                    int idy = Clamp(y + i,0, sourceImage.Height-1);
                    Color res = sourceImage.GetPixel(idx, idy);
                    redV.Add(res.R);
                    greenV.Add(res.G);
                    blueV.Add(res.B);
                }
            }
            redV.Sort();
            greenV.Sort();
            blueV.Sort();
            
            int mediana_id = redV.Count/2;
            return Color.FromArgb(redV[mediana_id], greenV[mediana_id], blueV[mediana_id]);
        }
    }
}
