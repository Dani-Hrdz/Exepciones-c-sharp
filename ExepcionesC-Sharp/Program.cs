using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionesC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("ingresa un numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("ingresa otro numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            catch(DivideByZeroException f)
            {
                Console.WriteLine(f.Message);
            }
            catch(FormatException a)
            {
                Console.WriteLine(a.Message);
            }
            finally { }
        }
    }
}
