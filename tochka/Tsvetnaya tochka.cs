using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochka
{
    internal class Tsvetnaya_tochka : TOchka
    {
        public string color { get; set; }
        public Tsvetnaya_tochka(double x, double y, string c)
        {
            X = x;
            Y = y;
            color = c;
        }
        public void Show()
        {
            Console.WriteLine($"Х={X}, Y={Y}");
        }
        public virtual void Draw()
        {
            Console.WriteLine($"Рисуем {color} точку");
        }
    }

}
