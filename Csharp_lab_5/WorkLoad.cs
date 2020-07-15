using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lab_5
{
    public class WorkLoad
    {
        public Teacher Teacher { get; set; }
        public Group Group { get; set; }
        public int NumberOfHours { get; set; }//Кол-во часов обучения
        public string Object { get; set; }//Предмет
        public string ClassType { get; set; }//Тип занятия
        public int Payment { get; set; }//Цена

    }
}
