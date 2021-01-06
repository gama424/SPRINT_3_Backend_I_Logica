using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1");
            
            Console.WriteLine("Digite o ano atual");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu ano de nascimento");
            int anoNascimento = int.Parse(Console.ReadLine());

            //processamento

            int idade = anoAtual-anoNascimento;

            Console.WriteLine(idade);

            //saida


            if(idade>=16){
                Console.WriteLine("Você pode votar");

            }else{
                Console.WriteLine("Você nao pode votar");
            }


            
        }
    }
}
