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
           
            string path = @"C:\Users\alina\source\repos\Tyuiu.GalimovaAS.Sprint5\Tyuiu.GalimovaAS.Sprint5.Task2.V27\bin\Debug\net8.0\OutPutFileTask2.txt";


            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}