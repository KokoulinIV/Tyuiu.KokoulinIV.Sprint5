using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.KokoulinIV.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            
            string str = File.ReadAllText(path);
            double x = double.Parse(str, CultureInfo.InvariantCulture);

            double y = Math.Round(Math.Pow((x * x) / (Math.Sin(x)), 3),3);
            return y;
        }
    }
}
