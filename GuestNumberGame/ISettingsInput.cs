using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberGame
{
    public interface ISettingsInput
    {
        (int, int) GetRange();
        int GetNumberOfAttempt();
    }
}
