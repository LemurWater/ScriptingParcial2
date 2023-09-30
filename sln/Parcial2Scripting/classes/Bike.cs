using Parcial2Scripting.classes.parts;
using Parcial2Scripting.classes.parts.wheels;
using Parcial2Scripting.interfaces;


namespace Parcial2Scripting.classes
{
    internal class Bike : ICheckExistence
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


        public Bike()
        {
            SetValues();
        }

        public Bike(FrontWheel frontWheel, BackWheel backWheel, Chassis chassis, Engine engine, Muffler muffler)
        {
            Speed = 0.0f;
            Acceleration = 0.0f;
            Handliong = 0.0f;
            Grip = grip;
            _FrontWheel = frontWheel;
            _BackWheel = backWheel;
            _Chassis = chassis;
            _Engine = engine;
            _Muffler = muffler;


            SetValues();
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

            CantBeAlone();
        }
        void CheckFrontWheel()
        {

        }
        void CheckBackWheel()
        {

        }
        void CheckChassis()
        {


            CantBeAlone();
        }
        void CheckEngine()
        {

        }
        void CheckMuffler()
        {

        }



        public void SwapFrontWheel(FrontWheel newFW)
        {



            CheckFrontWheel();
        }
        public void SwapBackWheel(BackWheel newBW)
        {


            CheckBackWheel();
        }
        public void SwapChassis(Chassis newChassis)
        {
            _Chassis = newChassis;

            CheckChassis();
        }
        public void SwapEngine(Engine newEngine)
        {


            CheckEngine();
        }
        public void SwapMuffler(Muffler newMuffler)
        {



            CheckMuffler();
        }


        public void CantBeAlone()
        {
            if(_Chassis == null)
            {
                Chassis c = new Chassis(1.0f, 1.0f, 1.0f, 1.0f); //Falta: crear random chassis
                SwapChassis(c);
            }
        }
    }
}
