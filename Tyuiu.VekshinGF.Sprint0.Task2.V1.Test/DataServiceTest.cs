using Tyuiu.VekshinGF.Sprint0.Task2.V1.Lib;

namespace Tyuiu.VekshinGF.Sprint0.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Григорий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Григорий", res);
        }
    }
}
