using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Race
{
    // класс для хранения скорости, цвета и счёта
     public class  Car
    {

        public int Speed { get; set; }

        public string Color { get; set; }

        public double score { get; set; }

        public Car(int s = 1, string c = "car_red", double sc = 0)  // конструктор с моментальной инициализацией
        {
            Speed = s;
            Color = c;
            score = sc;
        }
    }
}
