using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Csharp_lab_9
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            for (int testNumber = 0; testNumber < 20; testNumber++)
            {
                GenerateTest(testNumber + 1);
            }
        }
        

        static void GenerateTest(int testNumber)
        {
            
            string inputFilename = testNumber.ToString();
            string outputFilename = testNumber.ToString() + ".sort";
            /*int totalAnswer = 0;
            int linesNumber = random.Next(5) + 2; //колв-во строк от 2 до 51
            string[] stringBuilder = new string[linesNumber];
            for (int j = 0; j < linesNumber; j++)
            {
                int answerForLine = random.Next(10) + 1; //кол-во четных от 1 до 1000
                totalAnswer += answerForLine;
                stringBuilder[j] = GenerateLine(answerForLine, random.Next(30));
            }*/
            
            int count = 30;
            int[] nums = new int[count];
            for (int i = 0; i < count; i++)
            {
                nums[i] = random.Next(1, 50);
            }
            ///////////
            
            string[] numsString = new string[1];
            for(int i = 0; i < numsString.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    numsString[i] += nums[j] + " ";
                }
            }
            
            File.WriteAllLines(inputFilename, numsString);
            File.WriteAllText(outputFilename, Sort(nums));
        }
        static string Sort(int[] array)
        {
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
