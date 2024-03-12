using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberGame
{
    class GuessTheNumberGame : IGame
    {
        private readonly ISettingsInput settingsInput;
        private readonly IRandomNumberGenerator randomNumberGenerator;

        public GuessTheNumberGame(IRandomNumberGenerator randomNumberGenerator, ISettingsInput settingsInput)
        {
            this.randomNumberGenerator = randomNumberGenerator;
            this.settingsInput = settingsInput;
        }

        public void Start()
        {
            int maxAttempts = settingsInput.GetNumberOfAttempt();
            (int, int) ranges = settingsInput.GetRange();
            int maxNumber = ranges.Item1;
            int minNumber = ranges.Item2;
            int randomNumber = randomNumberGenerator.Generate(minNumber, maxNumber);

            int attempts = 0;

            Console.WriteLine($"Угадай число между {minNumber} и {maxNumber}.");

            while (attempts < maxAttempts)
            {
                Console.Write("Введите свое предположение: ");
                int guess;

                if (!int.TryParse(Console.ReadLine(), out guess) || guess < minNumber || guess > maxNumber)
                {
                    Console.WriteLine($"Пожалуйста, введите действительный номер между {minNumber} и {maxNumber}.");
                    continue;
                }

                attempts++;

                if (guess == randomNumber)
                {
                    Console.WriteLine($"Вы угадали число {randomNumber} правильно в {attempts} попытки.");
                    return;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Число больше, чем вы предполагаете.");
                }
                else
                {
                    Console.WriteLine("Число меньше вашего предположения.");
                }
            }

            Console.WriteLine($"Извините, вы использовали все {maxAttempts} попытки. Правильный номер был {randomNumber}.");
        }
    }
}
