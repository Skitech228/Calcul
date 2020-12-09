using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcul calcul = new Calcul();
            Console.WriteLine("Первое число");
            string a = calcul.GetIntBinaryString(Console.ReadLine());
            Console.WriteLine("Второе число");
            string b = calcul.GetIntBinaryString(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("* "+calcul.mul(a,b));
            Console.WriteLine("- " + calcul.sub(a, b));
            Console.WriteLine("+ " + calcul.add(a, b));
            Console.WriteLine("/ " + calcul.div(a, b));
            Console.Read();
        }
    }
}
