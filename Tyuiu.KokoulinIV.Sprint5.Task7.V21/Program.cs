using Tyuiu.KokoulinIV.Sprint5.Task7.V21.Lib;
namespace Tyuiu.KokoulinIV.Sprint5.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string str = "C:\\Users\\wolff\\source\\repos\\Tyuiu.KokoulinIV.Sprint5\\InPutDataFileTask7V21.txt.txt";
            Console.Title = "Спринт #5 | Выполнил Кокоулин И. В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Кокоулин Иван Владимирович   | ИБКСб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры. Заменить нечетные                  *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("*  Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string res = ds.LoadDataAndSave(str);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res + "Файл создан!");

            Console.ReadKey();
        }
    }
}
