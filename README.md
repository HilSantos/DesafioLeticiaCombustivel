# DesafioLeticiaCombustivel
Crie um programa em C# que leia o preço do litro da gasolina e o preço do litro do álcool. O programa deverá calcular qual combustível possui o menor preço por litro e indicar se o melhor combustível para o consumidor é o álcool ou a gasolina.
O programa deve apenas comparar os preços dos combustíveis e indicar qual deles é mais barato. Caso ambos tenham o mesmo preço, o programa deverá informar que os combustíveis têm o mesmo valor.

using System;

class Program
{
    static void Main()
    {
        // Entrada de dados
        Console.Write("Digite o preço do litro da gasolina: R$ ");
        double precoGasolina = Convert.ToDouble(Console.ReadLine());

  Console.Write("Digite o preço do litro do álcool: R$ ");
        double precoAlcool = Convert.ToDouble(Console.ReadLine());

  // Comparação e resultado
        if (precoGasolina < precoAlcool)
        {
            Console.WriteLine("Melhor opção: Gasolina (mais barata).");
        }
        else if (precoAlcool < precoGasolina)
        {
            Console.WriteLine("Melhor opção: Álcool (mais barato).");
        }
        else
        {
            Console.WriteLine("Os combustíveis têm o mesmo preço.");
        }
    }
}

// Exemplo de Saída //
Digite o preço do litro da gasolina: R$ 5.49
Digite o preço do litro do álcool: R$ 4.99
Melhor opção: Álcool (mais barato).
