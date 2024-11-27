using Tyuiu.KokoulinIV.Sprint5.Task6.V3.Lib;
using System.IO;

namespace Tyuiu.KokoulinIV.Sprint5.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool Exists = fileInfo.Exists;
            Assert.IsTrue(Exists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string a = "C:\\Users\\wolff\\source\\repos\\Tyuiu.KokoulinIV.Sprint5\\InPutDataFileTask6V3.txt.txt";
            int b = 21;
            int res = ds.LoadFromDataFile(a);
            Assert.AreEqual(b, res);
        }
    }
}