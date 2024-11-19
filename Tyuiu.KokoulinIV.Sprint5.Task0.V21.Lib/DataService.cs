using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KokoulinIV.Sprint5.Task0.V21.Lib
{
    public class DataService : ISprint5Task0V21
    {
        public string SaveToFileTextData(int x)
        {
            string filepath = "OutPutFileTask0.txt";
            double y = (x*x+1)/(Math.Pow(4*x*x-3, 0.5));
            y = Math.Round(y,2);
            File.WriteAllText(filepath, Convert.ToString(y));
            return filepath;
        }
    }
}
