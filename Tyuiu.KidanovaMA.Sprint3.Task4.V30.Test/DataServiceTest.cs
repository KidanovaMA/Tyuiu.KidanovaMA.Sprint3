using Tyuiu.KidanovaMA.Sprint3.Task4.V30.Lib;

namespace Tyuiu.KidanovaMA.Sprint3.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double wait = 1.924;
            double res = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
