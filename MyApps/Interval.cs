using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApps
{
    internal struct Interval
    {
        public int Min;
        public int Max;
        
        private Random random;

        public Interval(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                (minValue, maxValue) = (maxValue, minValue);
                Console.WriteLine("Неверно задан минимальная и максимальная граница интервала.");
            }
            if (minValue < 0)
            {
                minValue = 0;
                Console.WriteLine("Минимальная граница интервала не может быть меньше 0. Установлено значение 0");
            }
            if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine("Максимальная граница интервала не может быть меньше 0. Установлено значение 0");
            }
            if (minValue == maxValue)
            {
                maxValue += 10;
                Console.WriteLine("Максимальная граница интервала должна быть больше минимальной. Значение увеличено на 10");
            }

            Min = minValue;
            Max = maxValue;
            random = new Random();

            
        }

        public int Get()
        {
            return random.Next(Min, Max);
        }
        
    }
}
