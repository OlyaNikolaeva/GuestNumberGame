using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberGame
{
    interface IRandomNumberGenerator
    {
        int Generate(int min, int max);
    }
}
