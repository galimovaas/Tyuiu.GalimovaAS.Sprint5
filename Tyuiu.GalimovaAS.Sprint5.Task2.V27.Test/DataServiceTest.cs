using System.IO;
using Tyuiu.GalimovaAS.Sprint5.Task2.V27.Lib;
namespace Tyuiu.GalimovaAS.Sprint5.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\alina\AppData\Local\Temp\OutPutFileTask2.cvs";


            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}