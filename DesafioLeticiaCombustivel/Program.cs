using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLeticiaCombustivel
{
    public class Program
    {
        static void Main(string[] args)
        {
            //melhor opção de combustivel
            double Op, vAlcool, vGasolina;

            Console.WriteLine("Informe o valor do Alcool: ");
            vAlcool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor da Gasolina: ");
            vGasolina = Convert.ToDouble(Console.ReadLine());

            Op = vAlcool / vGasolina;
            //se o op<=0.7 melhor opção é o Alcool caso contrario é a Gasolina
            if (Op <= 0.7)
            {
                Console.WriteLine("Melhor opção é Alcool!");
            }
            else
            {
                Console.WriteLine("Melhor opção é Gasolina!");
            }
            Console.ReadKey();
        }
    }
}
