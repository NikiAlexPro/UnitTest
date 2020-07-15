using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace Csharp_lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Чтение 2 файлов:
            // 1 - файл с рандомными значениями
            // 2 - файл с отсортированными значениями
            // Использование класса "SortTest" для 1 файла
            // Сравнение результатов работы класса "SortTest" и 2 файла. 
            bool sucsess = true;
            try
            {
                var file = Directory.GetFiles(".", "????");
                for(int i = 0; i < file.Length; i++)
                {
                    var lines = File.ReadAllText(file[i]); //чтение файла
                    
                    //LINQ - 
                    int[] digits = lines.Split(' ')
                        .Where(x => x.All(s => char.IsDigit(s)))
                        .Select(x => Convert.ToInt32(x))
                        .ToArray();

                    var result = SortTest.Sort(digits);

                    var linesSort = File.ReadAllText(file[i] + ".sort"); // чтение отсортированного файла

                    //LINQ - //Trim(' ') - удаляет пробелы с начала и конца строки
                    int[] digitsresult = linesSort.Trim(' ').Split(' ')
                        .Where(x => x.All(s => char.IsDigit(s)))
                        .Select(x => Convert.ToInt32(x))
                        .ToArray();

                    //Сравнение
                    if(linesSort == result)
                    {
                        sucsess = true;
                        Console.WriteLine($"Test {file[i]} is done!");
                    }
                    else
                        Console.WriteLine($"Different answer {file[i]}");

                }

            }
            catch(Exception ex)
            {
                sucsess = false;
                Console.WriteLine($"Error Test {ex.Message}");
            }
            Console.ReadLine();
        }
    }

    class SortTest
    {
        //Сортировка 1 файла
        public static string Sort(int[] array)
        {
            array = array.ToArray();// Новый массив
            int even = 0; //четное
            int odd = 0; //нечетное
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even++;
                }
                else
                    odd++;
            }

            //Сортировка по возрастанию
            if (even > odd)
            {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;

                        }
                    }
                }
            }

            //Сортировка по убыванию
            else
            {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;

                        }
                    }
                }
            }

            //result
            string result = null;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }
            return result;
        }
    }
}
