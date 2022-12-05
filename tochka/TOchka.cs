using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochka
{
    internal class TOchka
    {
        public double X { get; set; }
        public double Y { get; set; }
        public TOchka(double x, double y)
        {
            X = x;
            Y = y;
        }
        public TOchka ()
        {

        }
        public virtual void Show()
        {
            Console.WriteLine($"Х={X}, Y={Y}");
        }
        public virtual void Draw()
        {
            Console.WriteLine("Рисуем точку");
        }
    }
}
