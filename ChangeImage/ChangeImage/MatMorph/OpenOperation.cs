using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeImage
{
    class OpenOperation : Filters
    {
        private int[,] structuralElement; // Структурный элемент
        private int elementRadius; // Радиус структурного элемента

        public OpenOperation(int[,] structuralElement)
        {
            this.structuralElement = structuralElement;
            this.elementRadius = structuralElement.GetLength(0) / 2; // Вычисляем радиус
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Operation operation = new Operation();
            Color erodedColor = operation.ApplyErosion(sourceImage , x, y, elementRadius, structuralElement);
            Color openedColor = operation.ApplyDilation(sourceImage, x, y, elementRadius, structuralElement);

            return openedColor;
        }
        
    }
}