using System;
using static System.Console;
using System.Runtime.InteropServices;

namespace EjericiosInicial
{
    public class Ejercicio3
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine($"longitud: {args.Length}");
            //foreach (var item in args)
            //{
            //    Console.WriteLine(item);
            //}

            // Opción1 Marshal.SizeOf(typeof(Int128)
            // Opción2 Unsafe 

            WriteLine("------------------------------------------------------------------------------------------------");
            WriteLine("{0,-10} {1,20} {2,40} {3,40}","Type", "Bytes of Memory", "Min", "Max"); 
            WriteLine("------------------------------------------------------------------------------------------------");
            WriteLine($"{typeof(sbyte).Name, -10} {sizeof(sbyte),20} {sbyte.MinValue, 40} {sbyte.MaxValue, 40}");
            WriteLine($"{typeof(Int128).Name,-10} {Marshal.SizeOf(typeof(Int128)), 20} {Int128.MinValue,40} {Int128.MaxValue,40}");

        }
    }

}
