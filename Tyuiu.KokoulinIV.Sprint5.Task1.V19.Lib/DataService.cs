using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KokoulinIV.Sprint5.Task1.V19.Lib

{
    public class DataService : ISprint5Task1V19
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string str;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Sin(x)+ 2/(3*x+0.5)-x*Math.Cos(x)*2*x;
                y = Math.Round(y, 2);
                if (3 * x + 0.5 == 0)
                {
                    y = 0;
                }
                str = Convert.ToString(y);
                
                if (x!=stopValue)
                {
                    File.AppendAllText(path, str+ Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }
            
            return path;
        }
    }
}
