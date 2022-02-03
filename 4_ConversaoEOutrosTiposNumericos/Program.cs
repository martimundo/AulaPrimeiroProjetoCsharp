using System;

namespace _4_ConversaoEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executado o projeto 4 - Outros tipos numericos e Conversões de tipos");

            double salario;
            salario = 1200.50;

            int salarioInteiro;
            salarioInteiro = (int)salario;//Conversão do do Tipo Casting

            Console.WriteLine("O valor atual do sálario é: "+salarioInteiro);
        }
    }
}
