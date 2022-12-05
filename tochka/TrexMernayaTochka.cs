using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochka
{
    internal class TrexMernayaTochka : TOchka
    {
        public double Z { get; set; }
        public TrexMernayaTochka(double x, double y,double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Х={X}, Y={Y}, Z={Z}");
        }
        public virtual void Draw()
        {
            Console.WriteLine($"Координаты точки: {X}, {Y}, {Z}");
        }
    }
}
