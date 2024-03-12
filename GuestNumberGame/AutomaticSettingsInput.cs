using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberGame
{
    public class AutomaticSettingsInput : ISettingsInput
    {
        private readonly Random _random = new Random();

        public (int, int) GetRange()
        {
            return (_random.Next(1, 10), _random.Next(10, 30));
        }

        public int GetNumberOfAttempt()
        {
            return _random.Next(1, 5);
        }
    }
}
