using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqwashies.AutoPetFeeder.Components
{
    public class Clock
    {

        public Clock()
        {

        }
        public DateTime GetTimeFromNavalClock()
        { 
            return DateTime.Now;
        }
        public bool IsClockSet()
        {

            if (DateTime.Now > DateTime.MinValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DateTime GetClockTime()
        {
            return DateTime.Now;
        }
    }
}
