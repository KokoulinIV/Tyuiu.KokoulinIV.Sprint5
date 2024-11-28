using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
namespace Tyuiu.KokoulinIV.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string pather = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V21.txt"); ;
            FileInfo fileInfo = new FileInfo(pather);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pather);
            }



            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != '.' && line[i] != '-' && line[i] != ',' && line[i] != '!' && line[i] != '?')
                        {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(pather, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pather;
        }
    }

       

}
