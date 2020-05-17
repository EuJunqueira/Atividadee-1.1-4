using System;

namespace ProgCarimbo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEXTO DO CARIMBO: ");
            string texto1 = Console.ReadLine();
            Console.WriteLine("QUAL A COR DO CARIMBO: ");
            string cor1 = Console.ReadLine();
            Console.WriteLine("QUANTAS CARGAS NO CARIMBO: ");
            int carga1 = Convert.ToInt32(Console.ReadLine());
            Carimbo use1 = new Carimbo(texto1);


            use1.carregar(cor1, carga1);
            use1.usar();

        }
    }
}
