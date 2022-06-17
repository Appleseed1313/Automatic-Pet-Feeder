using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqwashies.AutoPetFeeder.Components
{
    public class Scheduler
    {

        public Scheduler()
        {
            this.TurnedOn = true;
            this.IsBreakfastTime = false;
            this.IsDinnerTime = false;
        }


        public bool IsSchedulerTurnedOn()
        {
            return this.TurnedOn;
        }

        public bool IsFeedingTime()
        {
            var clock = new Clock();
            var time = clock.GetClockTime();
            var breakfastTime = "7:00 AM";
            var dinnerTime = "7:34 PM";

            Console.WriteLine("The current time is:" + time.ToShortTimeString());

            if (time.ToShortTimeString() == breakfastTime)
            {
                this.IsBreakfastTime = true;
                return this.IsBreakfastTime;
            }

            if (time.ToShortTimeString() == dinnerTime)
            {
                this.IsDinnerTime = true;
                return this.IsDinnerTime;
            }

            return false;
        }

        public bool TurnedOn { get; set; }

        public bool IsBreakfastTime { get; set; }

        public bool IsDinnerTime { get; set; }
    }
}
