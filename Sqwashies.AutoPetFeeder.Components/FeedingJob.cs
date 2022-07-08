using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sqwashies.AutoPetFeeder.Components;
//using Sqwashies.AutoPetFeeder.Web.Data;

namespace Sqwashies.AutoPetFeeder.Components
{
    public class FeedingJob
    {
       public void Begin()
        {
            try
            {
                var clock = new Clock();
                bool clockIsSet = clock.IsClockSet();

                if (clockIsSet)
                {
                    Console.WriteLine("The time is:" + clock.GetClockTime());
                    var scheduler = new Scheduler();
                    bool schedulerOn = scheduler.IsSchedulerTurnedOn();

                    while (schedulerOn)
                    {
                        Console.WriteLine("Scheduler is On!");

                        bool isFeedingTime = scheduler.IsFeedingTime();

                        if (isFeedingTime)
                        {
                            if (scheduler.IsBreakfastTime)
                            {
                                Console.WriteLine("Dispense Breakfast");
                                var breakfastDispenser = new Dispenser();
                                breakfastDispenser.DispenseBreakfast();
                               
                            }

                            if (scheduler.IsDinnerTime)
                            {
                                Console.WriteLine("Dispense Dinner");
                                var dinnerDispenser = new Dispenser();
                                dinnerDispenser.DispenseDinner();
                               
                            }
                        }
                        else
                        {
                            Console.WriteLine("It's not time to dispense food: Waiting another minute");
                           
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Need to get time from naval clock");
                    clock.GetTimeFromNavalClock();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

           


        }


    }

}
