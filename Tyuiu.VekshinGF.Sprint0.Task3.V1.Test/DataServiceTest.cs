using Tyuiu.VekshinGF.Sprint0.Task3.V1.Lib;

namespace Tyuiu.VekshinGF.Sprint0.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(11, DataService.Sum(6, 5));
        }
    }
}
