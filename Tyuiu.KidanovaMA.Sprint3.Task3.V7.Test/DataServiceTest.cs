using Tyuiu.KidanovaMA.Sprint3.Task3.V7.Lib;

namespace Tyuiu.KidanovaMA.Sprint3.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char replaceble = 'g';
            char replacement = '4';
            string wait = "4ft h44t nt4";
            string res = ds.ReplaceCharOnNum(value, replaceble, replacement);

            Assert.AreEqual(wait, res);
        }
    }
}
