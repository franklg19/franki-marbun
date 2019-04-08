using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_prosedur_dan_fungsi
{
    class Program
    {
        private static void Garis()
        {
            Console.WriteLine(new string('_', 30));
        }
        private static void Tulisan()
        {
            Console.WriteLine("Belajar fungsi dan prosedur");
            Console.Write("selesai sampai disini saja");
        }
   

        static void Main(string[] args)
        {
            
            Garis();
            Tulisan();
            Console.WriteLine();
            Garis();
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
