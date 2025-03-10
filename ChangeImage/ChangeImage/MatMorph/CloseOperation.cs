using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class CloseOperation : Filters
    {
        private int[,] structuralElement; // Структурный элемент
        private int elementRadius; // Радиус структурного элемента

        public CloseOperation(int[,] structuralElement)
        {
            this.structuralElement = structuralElement;
            this.elementRadius = structuralElement.GetLength(0) / 2; // Вычисляем радиус
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Operation operation = new Operation();
            Color dilatedColor = operation.ApplyDilation(sourceImage, x, y, elementRadius, structuralElement);
            Color closedColor = operation.ApplyErosion(sourceImage, x, y, elementRadius, structuralElement);
            return closedColor;
        }
    }
}
