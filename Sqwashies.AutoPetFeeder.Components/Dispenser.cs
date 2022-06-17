using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqwashies.AutoPetFeeder.Components
{
    public class Dispenser
    {

        public Dispenser()
        {

        }

        public void DispenseBreakfast()
        {
            Console.WriteLine("Dispensing Breakfast");
            var servomotor = new MyServoMotor();
            servomotor.Turn180Open();
            Thread.Sleep(1000); // 1 cup of food
            servomotor.Turn180Close();
        }

        public void DispenseDinner()
        {
            Console.WriteLine("Dispensing Dinner");
            var servomotor = new MyServoMotor();
            servomotor.Turn180Open();
            Thread.Sleep(2000); // 2 cup of food
            servomotor.Turn180Close();
        }
    }
    }


