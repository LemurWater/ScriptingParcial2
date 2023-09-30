using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting.classes.parts
{
    internal abstract class Wheel : Part
    {
        public Wheel(float speed, float acceleration, float handling, float grip) : base(speed, acceleration, handling, grip)
        {
            Speed = speed;
            Acceleration = acceleration;
            Handling = handling;
            Grip = grip;
        }

        public override void CheckAttribute()
        {
            throw new NotImplementedException();
        }
    }
}
