using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
using System.Data.SqlTypes;
namespace Tyuiu.KokoulinIV.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            double minValue = double.MaxValue;
            string str = File.ReadAllText(path);
            string[] strings = str.Split(' ');
            List<string> odd= new List<string>();
            foreach (string s in strings)
            {
                if( double.TryParse(s,out double number))
                {
                    if(number < minValue)
                    {
                        minValue = number;
                    }
                }
            }

            
            return minValue;
        }
    }
}
