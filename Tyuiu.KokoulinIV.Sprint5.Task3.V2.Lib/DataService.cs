using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KokoulinIV.Sprint5.Task3.V2.Lib
{
    public class DataService : ISprint5Task3V2
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.txt"); ;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;

            y = (Math.Pow(Math.E, x)) / x;
            if (x==0)
            {
                y = 0;
            }
            y = Math.Round(y,3);
            using (BinaryWriter write = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), System.Text.Encoding.UTF8))
            {
                write.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
