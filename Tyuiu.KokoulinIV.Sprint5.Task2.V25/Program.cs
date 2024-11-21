using Tyuiu.KokoulinIV.Sprint5.Task2.V25.Lib;
namespace Tyuiu.KokoulinIV.Sprint5.Task2.V25
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
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры. Заменить нечетные                  *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("*  Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] ints = new int[3, 3];
            Console.WriteLine("Введите массив размером 3/3 " );
            for ( int i = 0; i < ints.GetLength(0); i++ )
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.WriteLine($"Введите значение {i+1} / {j+1}");
                    ints[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            string res = ds.SaveToFileTextData(ints);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл:" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
