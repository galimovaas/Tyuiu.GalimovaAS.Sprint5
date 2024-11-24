using System.IO;
using Tyuiu.GalimovaAS.Sprint5.Task3.V7.Lib;
namespace Tyuiu.GalimivaAS.Sprint5.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            string path = @"C:\Users\alina\AppData\Local\Temp\OutPutFileTask3.bin";


            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}