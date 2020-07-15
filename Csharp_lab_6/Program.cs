using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lab_6
{
    class Program
    {
        private const string V = "Работа с файловой системой";

        static void Main()
        {
            Post post1 = new Post { Message = V, Author = "qwe", Date = new DateTime() };
            post1.CountRating();
            post1.Result();
            Console.ReadLine();
        }
    }
    public class Post
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        /// <summary>
        /// Определяет "рейтинг" сообщения
        /// </summary>
        /// <returns>Значение "рейтинга"</returns>
        public double CountRating()
        {
            var rating = 0.3 * CountFirstParam() + 0.7 * CountSecondParam();
            return rating;
        }
        public void Result()
        {
            Console.WriteLine($"CountFirstParam = {CountFirstParam()}");
            Console.WriteLine($"CountSecondParam = {CountSecondParam()}");
            Console.WriteLine($"CountRating = {CountRating()}");
        }
        /// <summary>
        /// Определяет "простой" параметр "полезности" сообщения (кол-во букв в сообщении)
        /// </summary>
        /// <returns>Значение "простого" параметра "полезности" сообщения</returns>
        private double CountFirstParam()
        {
            int param = 0;
            for(int i = 0; i < Message.Length; i++)
            {
                if(Message[i] != ' ')
                {
                    param++;
                }
            }
            //double param = Message.Count(char.IsLetterOrDigit);
            return param;
        }//Count(Char.IsLetter)
        /// <summary>
        /// Определяет "сложный" параметр "полезности" сообщения (кол-во различных слов в сообщении)
        /// </summary>
        /// <returns>Значение "сложного" параметра "полезности" сообщения</returns>
        private double CountSecondParam()
        {
            var split = new[] {' ', ',', ':', '.', '!' , '-' };
            double param = Message.Split(split, StringSplitOptions.RemoveEmptyEntries).Distinct().Count();
            return param;
        }
    }
}
