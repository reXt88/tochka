using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TOchka a = new TOchka(4,5);
            a.Show();
            a.Draw();
            Tsvetnaya_tochka b = new Tsvetnaya_tochka(8,2,"Blue");
            b.Show();
            b.Draw();
            TrexMernayaTochka c = new TrexMernayaTochka(1, 5, 9);
            c.Show();
            c.Draw();
            Console.ReadLine();
        }
    }
}
