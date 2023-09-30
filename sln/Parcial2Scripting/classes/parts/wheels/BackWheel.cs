using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting.classes.parts.wheels
{
    internal class BackWheel : Wheel
    {
        public BackWheel(float speed, float acceleration, float handling, float grip) : base(speed, acceleration, handling, grip)
        {
            Speed = speed;
            Acceleration = acceleration;
            Handling = Handling;
            Grip = Grip;
        }
    }
}
