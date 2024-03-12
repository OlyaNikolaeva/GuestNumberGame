using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberGame
{
    public class CustomSettingsInput : ISettingsInput
    {
        public (int, int) GetRange()
        {
            int maxRange;
            int minRange;

            Console.Clear();
            Console.WriteLine("Настройка диапазона.");
            Console.WriteLine("1. Введите максимальное число выбора:");
            while (!int.TryParse(Console.ReadLine(), out maxRange))
            {
                Console.WriteLine("Неверное число. Введите целое число.");
            }

            Console.WriteLine("2. Введите минимальное число выбора:");
            while (!int.TryParse(Console.ReadLine(), out minRange) || minRange > maxRange)
            {
                Console.WriteLine("Неверное число. Введите целое число меньше чем максимальное число.");
            }

            return (maxRange, minRange);
        }

        public int GetNumberOfAttempt()
        {
            int attempt;

            Console.Clear();
            Console.WriteLine("Введите кол-во попыток:");

            while (!int.TryParse(Console.ReadLine(), out attempt) || attempt < 0)
            {
                Console.WriteLine("Неверный ввод. Введите положительное целое число.");
            }

            return attempt;
        }
    }
}
