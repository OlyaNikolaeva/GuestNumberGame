using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberGame
{
    class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random random = new Random();

        public int Generate(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}
