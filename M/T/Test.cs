using M.Modeli;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.T
{
    public class Test
    {
        [Test]
        public void TestTrainSize()
        {
            Trains smallTrain = new Trains(Trains.Velicina.Small);
            Assert.AreEqual(smallTrain.GetSize(), Trains.Velicina.Small);
            Console.WriteLine("Test 1 passed");

            Assert.AreEqual(smallTrain.GetCapacity(), 8);
            Console.WriteLine("Test 2 passed");

            Trains largeTrain = new Trains(Trains.Velicina.Large);
            Assert.AreEqual(largeTrain.GetSize(), Trains.Velicina.Large);
            Console.WriteLine("Test 3 passed");
            Assert.AreEqual(largeTrain.GetCapacity(), 6);
            Console.WriteLine("Test 4 passed");
        }
    }
}
