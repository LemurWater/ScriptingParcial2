using Parcial2Scripting.classes;
using Parcial2Scripting.classes.parts;
using Parcial2Scripting.classes.parts.wheels;

namespace Parcial2Scripting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BikeCanBeCreated()
        {
             FrontWheel frontWheel = new(1.0f, 1.0f, 1.0f, 1.0f);
             BackWheel backWheel = new(1.0f, 1.0f, 1.0f, 1.0f);
             Chassis chassis = new(1.0f, 1.0f, 1.0f, 1.0f);
             Engine engine = new(1.0f, 1.0f, 1.0f, 1.0f);
             Muffler muffler = new(1.0f, 1.0f, 1.0f, 1.0f);

             Bike bikeChassis = new Bike(frontWheel, backWheel, chassis, engine, muffler);

             chassis = null;
             Bike bikeNOChassis = new Bike(frontWheel, backWheel, chassis, engine, muffler);

             if (bikeChassis._Chassis != null && bikeNOChassis._Chassis != null)
             {
                 Assert.Pass();
             }
             else Assert.Fail();
        }

        [Test]
        public void BikesCanBeUsed()
        {
            bool canDrive = true;
            List<Bike> bikes = new();

            FrontWheel frontWheel = new(1.0f, 1.0f, 1.0f, 1.0f);
            BackWheel backWheel = new(1.0f, 1.0f, 1.0f, 1.0f);
            Chassis chassis = new(1.0f, 1.0f, 1.0f, 1.0f);
            Engine engine = new(1.0f, 1.0f, 1.0f, 1.0f);
            Muffler muffler = new(1.0f, 1.0f, 1.0f, 1.0f);

            Engine noEngine = null;
            FrontWheel noFrontWheel = null;
            Muffler noMuffler = null;

            Bike bikeAllParts = new Bike(frontWheel, backWheel, chassis, engine, muffler);
            //Bike bikeNoMotor = new Bike(frontWheel, backWheel, chassis, noEngine, muffler);
            //Bike bikeNoWheel = new Bike(noFrontWheel, backWheel, chassis, engine, muffler);
            //Bike bikeNoMuffle = new Bike(frontWheel, backWheel, chassis, engine, noMuffler);

            bikes.Add(bikeAllParts);
            //bikes.Add(bikeNoMotor);
            //bikes.Add(bikeNoWheel);
            //bikes.Add(bikeNoMuffle);

            foreach(Bike bike in bikes)
            {
                if(bike._FrontWheel == null) canDrive = false;
                if(bike._Engine == null) canDrive = false;
                if(bike._FrontWheel == null) canDrive = false;
                if(bike._Muffler == null) canDrive = false;
            }

            if (canDrive) Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void PartCanBeAdded()
        {
            BackWheel backWheel = new(1.0f, 1.0f, 1.0f, 1.0f);
            Chassis chassis = new(1.0f, 1.0f, 1.0f, 1.0f);
            Engine engine = new(1.0f, 1.0f, 1.0f, 1.0f);
            Muffler muffler = new(1.0f, 1.0f, 1.0f, 1.0f);

            FrontWheel newFrontWheel = new(1.0f, 1.0f, 1.0f, 1.0f);
            FrontWheel noFrontWheel = null;

            Bike bikeNoFrontWheel = new Bike(null, backWheel, chassis, engine, muffler);
            bikeNoFrontWheel.SwapFrontWheel(newFrontWheel);

            if (bikeNoFrontWheel._FrontWheel == null)
            {
                Assert.Fail();
                return;
            }
            BackWheel newBackWheel = new(1.0f, 1.0f, 1.0f, 1.0f);
            bikeNoFrontWheel.SwapBackWheel(newBackWheel);

            if (bikeNoFrontWheel._BackWheel == null)
            {
                Assert.Fail();
                return;
            }

            Muffler newMuffler = new(1.0f, 1.0f, 1.0f, 1.0f);
            bikeNoFrontWheel._Muffler = null;
            bikeNoFrontWheel.SwapMuffler(newMuffler);
            if (bikeNoFrontWheel._Muffler == null)
            {
                Assert.Fail();
                return;
            }
 


            Assert.Pass();
        }

        [Test]
        public void PartsModifyParameters()
        {
            Assert.Fail();
        }

        [Test]
        public void MaxParameterValueOnConstructor()
        {
            Assert.Fail();
        }
    }
}