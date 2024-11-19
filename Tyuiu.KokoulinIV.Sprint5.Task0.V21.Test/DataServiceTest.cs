using Tyuiu.KokoulinIV.Sprint5.Task0.V21.Lib;
using System.IO;

namespace Tyuiu.KokoulinIV.Sprint5.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\wolff\source\repos\Tyuiu.KokoulinIV.Sprint5\Tyuiu.KokoulinIV.Sprint5.Task0.V21\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileWxists = fileInfo.Exists;
            bool wail = true;
            Assert.AreEqual(wail, fileWxists);


        }
    }
}