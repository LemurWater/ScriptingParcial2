using Parcial2Scripting.classes.parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting.classes
{
    internal class Bike
    {
        private float speed;
        private float acceleration;
        private float handliong;
        private float grip;


        private FrontWheel frontWheel;
        private BackWheel backWheel;
        private Chassis chassis;
        private Engine engine;
        private Muffler muffler;

        public Bike(FrontWheel frontWheel, BackWheel backWheel, Chassis chassis, Engine engine, Muffler muffler)
        {
            Speed = 0.0f;
            Acceleration = 0.0f;
            Handliong = 0.0f;
            Grip = grip;
            _FrontWheel = frontWheel ?? throw new ArgumentNullException(nameof(frontWheel));
            _BackWheel = backWheel ?? throw new ArgumentNullException(nameof(backWheel));
            _Chassis = chassis ?? throw new ArgumentNullException(nameof(chassis));
            _Engine = engine ?? throw new ArgumentNullException(nameof(engine));
            _Muffler = muffler ?? throw new ArgumentNullException(nameof(muffler));
        }

        public float Speed { get => speed; set => speed = value; }
        public float Acceleration { get => acceleration; set => acceleration = value; }
        public float Handliong { get => handliong; set => handliong = value; }
        public float Grip { get => grip; set => grip = value; }
        
        
        
        internal FrontWheel _FrontWheel { get => frontWheel; set => frontWheel = value; }
        internal BackWheel _BackWheel { get => backWheel; set => backWheel = value; }
        internal Chassis _Chassis { get => chassis; set => chassis = value; }
        internal Engine _Engine { get => engine; set => engine = value; }
        internal Muffler _Muffler { get => muffler; set => muffler = value; }
    
    
    
    
    
        public void SetValues()
        {
            CheckFrontWheel();
            CheckBackWheel();
            CheckChassis();
            CheckEngine();
            CheckMuffler();
        }
        void CheckFrontWheel()
        {

        }
        void CheckBackWheel()
        {

        }
        void CheckChassis()
        {

        }
        void CheckEngine()
        {

        }
        void CheckMuffler()
        {

        }
    }
}
