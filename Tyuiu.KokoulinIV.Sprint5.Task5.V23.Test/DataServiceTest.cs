namespace Tyuiu.KokoulinIV.Sprint5.Task5.V23.Test
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
    }
}