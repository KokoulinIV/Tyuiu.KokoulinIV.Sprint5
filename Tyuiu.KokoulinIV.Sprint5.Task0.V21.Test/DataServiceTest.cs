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
            string path = Path.GetTempPath();
            FileInfo ra = new FileInfo(path);
            bool fileEx = ra.Exists;
            Assert.AreEqual(true, fileEx);


        }
    }
}