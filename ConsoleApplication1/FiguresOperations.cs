using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class FiguresOperations
    {
        /// <summary>
        /// Calculates square of right triangle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double Square(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Triangle side cannot be less or equal zero");

            double[] sides = new double[] { a, b, c };
            Array.Sort< double>(sides);
            Array.Reverse(sides);//sides[0] будет гипотенузой как самая большая
            //Если теорема Пифагора не выполняется выкидываем exception
            if (Math.Pow(sides[0],2) != (Math.Pow(sides[1],2) + Math.Pow(sides[2],2)))
            {
                throw new ArgumentException("Triangle with such sides doesn't exist");
            }

            return sides[1] * sides[2] / 2;//Площадь прямоугольного треугольника
        }
    }
}
