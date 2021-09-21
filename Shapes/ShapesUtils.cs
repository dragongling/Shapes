using System;

/*
 * Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
   - Юнит-тесты
   - Легкость добавления других фигур
   - Вычисление площади фигуры без знания типа фигуры в compile-time
   - Проверку на то, является ли треугольник прямоугольным
 */

namespace Shapes
{
    public static class ShapesUtils
    {
        public static double GetTriangleAreaBySides(double a, double b, double c)
        {
            throw new NotImplementedException();
        }

        public static double GetCircleArea(double radius)
        {
            throw new NotImplementedException();
        }
    }
}
