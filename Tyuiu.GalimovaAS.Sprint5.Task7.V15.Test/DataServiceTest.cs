using System.IO;
using Tyuiu.GalimovaAS.Sprint5.Task7.V15.Lib;
namespace Tyuiu.GalimovaAS.Sprint5.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask7V15.txt" });
            var res = ds.LoadDataAndSave(path);
            Assert.AreEqual(Path.Combine(new string[] { "C:", "DataSprint5", "OutPutDataFileTask7V15.txt" }), res);
        }
    }
}
