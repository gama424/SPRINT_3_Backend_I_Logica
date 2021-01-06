using System;

namespace atividades
{
    class Tabuada
    {
        static void Main(string[] args)
        {
         
                
            // for (var contador = 1; contador < 11; contador++)
            // {
            //     Console.WriteLine("digite um valor");
            //     int valor = int.Parse(Console.ReadLine());
            //     Console.WriteLine($"Você digitou: {valor}");

                
                
            // }
            int conta,i , numero;

           
            Console.Write("Digite um número para ver a tabuada: ");
            numero = int.Parse(Console.ReadLine());

            
            for ( i = 1; i <= 10; ++i)
            {
                conta =  numero * i;
                Console.WriteLine(numero + " X " + i + " = " + conta);
                
            }


        }
    }
}