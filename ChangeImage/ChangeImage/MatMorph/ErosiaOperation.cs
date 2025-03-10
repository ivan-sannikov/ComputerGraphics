using System;
using System.Drawing;

namespace ChangeImage
{
    class ErosiaOperation : Filters
    {
        private int[,] structuralElement; // Структурный элемент
        private int elementRadius; // Радиус структурного элемента

        // Конструктор с параметром для настройки структурного элемента
        public ErosiaOperation(int[,] structuralElement)
        {
            this.structuralElement = structuralElement;
            this.elementRadius = structuralElement.GetLength(0) / 2; // Вычисляем радиус
        }

        // Переопределяем метод calculateNewPixelColor для эрозии
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            // Инициализируем минимальное значение (для бинарного изображения это 0)
            int minIntensity = 255;

            // Проходим по окрестности, заданной структурным элементом
            for (int i = -elementRadius; i <= elementRadius; i++)
            {
                for (int j = -elementRadius; j <= elementRadius; j++)
                {
                    // Проверяем, активен ли текущий элемент в структурном элементе
                    if (structuralElement[i + elementRadius, j + elementRadius] == 1)
                    {
                        // Вычисляем координаты соседнего пикселя
                        int neighborX = Clamp(x + j, 0, sourceImage.Width - 1);
                        int neighborY = Clamp(y + i, 0, sourceImage.Height - 1);

                        // Получаем интенсивность соседнего пикселя
                        Color neighborColor = sourceImage.GetPixel(neighborX, neighborY);
                        int intensity = (int)(0.299 * neighborColor.R + 0.587 * neighborColor.G + 0.114 * neighborColor.B);

                        // Находим минимальную интенсивность в окрестности
                        if (intensity < minIntensity)
                            minIntensity = intensity;
                    }
                }
            }

            // Возвращаем новый цвет на основе минимальной интенсивности
            return Color.FromArgb(minIntensity, minIntensity, minIntensity);
        }
    }
}