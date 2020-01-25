using System;

namespace Numero_a_Cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string valor = "";

            Console.WriteLine("Digite el Numero");
            valor = Console.ReadLine();
            num = Convert.ToInt32(valor);

            cadena();

        }

        static void cadena()
        {
            Console.WriteLine("Hola Mundo");

        }

    }
}
