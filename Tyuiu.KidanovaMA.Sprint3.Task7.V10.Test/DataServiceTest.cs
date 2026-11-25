using Tyuiu.KidanovaMA.Sprint3.Task7.V10.Lib;

namespace Tyuiu.KidanovaMA.Sprint3.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] wait = { -15.40, -13.31, -11.36, -8.00, -2.62, 1.83, 4.49, 6.78, 10.58, 17.38, 23.76 };
            double[] res = ds.GetMassFunction(startValue, stopValue);
            Assert.AreEqual(wait.Length, res.Length);
            for (int i = 0; i < wait.Length; i++)
            {
                Assert.AreEqual(wait[i], res[i], 0.01);
            }
        }
    }
}
