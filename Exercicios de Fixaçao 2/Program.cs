using System;

namespace exercicios_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota");
            int nota;

            nota = int.Parse(Console.ReadLine());

            while(nota<0 || nota>10){
                Console.WriteLine("Nota Inválida");

            }




        }
    }
}
