using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitRecursion
{
    internal class Program
    {
        static void Echo(string phrase, int deep)
        {
            var modif = phrase;
            Console.WriteLine("..." + modif);
            if(modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            if(deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите фразу");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);
        }
    }
}
