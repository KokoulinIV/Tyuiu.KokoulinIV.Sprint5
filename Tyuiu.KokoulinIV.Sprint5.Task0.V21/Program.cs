using Tyuiu.KokoulinIV.Sprint5.Task0.V21.Lib;
namespace Tyuiu.KokoulinIV.Sprint5.Task0.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнил Кокоулин И. В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Кокоулин Иван Владимирович   | ИБКСб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"246813579\".                        *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и                                      *");
            Console.WriteLine("* подсчитайте количество четных чисел.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine("x = "+ x);
            
            string res = ds.SaveToFileTextData(x);

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл:" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
