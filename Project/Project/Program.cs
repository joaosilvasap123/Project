using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*** 
             Recebe o primeiro valor
             ***/

            Console.WriteLine("Digite o primeiro valor: ");
            decimal Val1 = Convert.ToDecimal(Console.ReadLine());

            /*** 
             Recebe o segundo valor
             ***/

            Console.WriteLine("Digite o segundo valor: ");
            decimal Val2 = Convert.ToDecimal(Console.ReadLine());

            /*** 
            Realiza o cálculo de soma entre os valores
            ***/

            decimal Total = Val1 + Val2;

            /*** 
            Mostra o resultado total
            ***/

            Console.WriteLine("O total é: " + Total);

            Console.ReadLine();
        }
    }
}
