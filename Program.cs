using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os lados do triângulo desejado: ");

            Console.WriteLine("Lado 1: ");
            double pri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lado 2: ");
            double seg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lado 3: ");
            double ter = Convert.ToDouble(Console.ReadLine());

           double semiperimetro = (pri + seg + ter) / 2;
           Console.WriteLine($"Semiperímetro: {semiperimetro}");

           // Dividi em várias linhas pois quando pus em uma linha só o resultado não saia
           double areaUM = semiperimetro - pri; 
           double areaDois = semiperimetro - seg;
           double areaTres = semiperimetro - ter;  
           double area = semiperimetro * areaUM * areaDois * areaTres; 
           double areaResultado = Math.Sqrt(area); 
           Console.WriteLine($"Área: {areaResultado}");

        }
    }
}
