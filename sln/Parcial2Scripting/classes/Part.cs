using Parcial2Scripting.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting.classes
{
    internal abstract class Part : ICantModify
    {
        private float speed;
        private float acceleration;
        private float handling;
        private float grip;



        public float Speed { get => speed; set => speed = value; }
        public float Acceleration { get => acceleration; set => acceleration = value; }
        public float Handling { get => handling; set => handling = value; }
        public float Grip { get => grip; set => grip = value; }



        public abstract void CheckAttribute();
    }
}
