using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class GlassEffectFilter : Filters
    {
        private Random random = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            double randX = random.NextDouble(); 
            double randY = random.NextDouble(); 
            int newX = x + (int)((randX - 0.5) * 10);
            int newY = y + (int)((randY - 0.5) * 10);
            newX = Clamp(newX, 0, sourceImage.Width - 1);
            newY = Clamp(newY, 0, sourceImage.Height - 1);
            return sourceImage.GetPixel(newX, newY);
        }
    }
}
