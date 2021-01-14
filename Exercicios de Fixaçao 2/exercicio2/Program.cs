using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
                string nome, senha;

            Console.WriteLine("Digite seu Usuario");
            nome = Console.ReadLine();

            
            Console.WriteLine("Digite sua Senha");
            senha = Console.ReadLine();

            while(nome == senha){
                Console.WriteLine("errou seu cabeça de vento");

                
                 Console.WriteLine("Digite seu Usuario");
                nome = Console.ReadLine();

            
                Console.WriteLine("Digite sua Senha");
                senha = Console.ReadLine();

            }


        }
    }
}
