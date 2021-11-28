using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_15_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double desc, sal, vdesc, sal_liq;
            
            //entradas

            Console.WriteLine("Informe o seu salário.");
            sal = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o % de desconto.");
            vdesc = double.Parse(Console.ReadLine());

            //processamento

            sal_liq = sal - (sal * vdesc / 100) ;
            
            

            //saída

           
            Console.WriteLine("O sálário líquido é de " + sal_liq.ToString("C"));

            Console.ReadKey();






        }
    }
}
