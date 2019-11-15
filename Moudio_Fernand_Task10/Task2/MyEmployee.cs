using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyEmployee
    {
        public Person[] GetMyEmployees()
        {
            Person[] arr = {
                new Person(){Name = "Фернанд Моудио", Time = 7},
                new Person(){Name = "Муидинь Муса", Time = 7},
                new Person(){Name = "Лудениять Ассума", Time = 7},
                new Person(){Name = "Леонни Абдулай", Time = 8},
                new Person(){Name = "Маруфату Адаму", Time = 8},
                new Person(){Name = "Жоел Мпеня", Time = 8},
                new Person(){Name = "Андре Сильва", Time = 13},
                new Person(){Name = "Елисее Моудио", Time = 13},
                new Person(){Name = "Паскаль Боско", Time = 13},
                new Person(){Name = "Корине Чато", Time = 18},
                new Person(){Name = "Идая Адаму", Time = 18},
                new Person(){Name = "Рума шу", Time = 18}
            };
            return arr;
        }
    }
}
