using Iot.Device.ServoMotor;
using System;
using System.Collections.Generic;
using System.Device.Pwm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqwashies.AutoPetFeeder.Components
{
    public class MyServoMotor
        
       
    {
        public MyServoMotor()
        {
           
        }

        public void Turn180Open()
        {
            Console.WriteLine("Turning 180 degrees to open");
            // Example of hardware PWM using chip 0 and channel 0 on a dev board.
            //ServoMotor servoMotor = new ServoMotor(PwmChannel.Create(0, 0, 50));
            //servoMotor.Start();  // Enable control signal.

            // Move position.  Pulse width argument is in microseconds.

            //servoMotor.WritePulseWidth(2000); // 2ms; Approximately 180 degrees.

            //servoMotor.Stop(); // Disable control signal.
        }
        public void Turn180Close()
        {
            Console.WriteLine("Turning 180 degrees to close");
            // Example of hardware PWM using chip 0 and channel 0 on a dev board.
            //ServoMotor servoMotor = new ServoMotor(PwmChannel.Create(0, 0, 50));
            //servoMotor.Start();  // Enable control signal.

            //// Move position.  Pulse width argument is in microseconds.
            
            //servoMotor.WritePulseWidth(2000); // 2ms; Approximately 180 degrees.

            //servoMotor.Stop(); // Disable control signal.
        }
    }

}
