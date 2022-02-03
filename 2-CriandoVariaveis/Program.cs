using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Variáveis em Csharp - Projeto 2");

            int idade = 32;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine(idade);
            Console.WriteLine("Sua idade é: "+idade);
            

        }
    }
}
