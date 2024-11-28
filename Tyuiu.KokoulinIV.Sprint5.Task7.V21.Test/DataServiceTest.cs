using Tyuiu.KokoulinIV.Sprint5.Task7.V21.Lib;
using System.IO;

namespace Tyuiu.KokoulinIV.Sprint5.Task7.V21.Test
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
                string a = "C:\\Users\\wolff\\source\\repos\\Tyuiu.KokoulinIV.Sprint5\\InPutDataFileTask7V21.txt.txt";
                string wail = "Стока и точка";
                string b = ds.LoadDataAndSave(a);
                string str = File.ReadAllText(b);
                String.Equals(wail,str);
            }
        
    }
}