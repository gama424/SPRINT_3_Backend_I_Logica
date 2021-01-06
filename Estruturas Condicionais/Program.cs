using System;

namespace condicionais
{
    class Program
    {
        private static float media;

        static void Main(string[] args)
        {
        //    string nomePai,  nomeFilho;         //declaramos a variável
        //         nomePai = "Darth Vader";
        //        Console.WriteLine(nomePai);

        //         nomeFilho = "Luke";
        //         Console.WriteLine(nomeFilho);

        //          Console.WriteLine("o pai de "+nomeFilho+" é o Darth Vader");
    
            //declarar as variaveis
            float nota1, nota2, nota3;

            //entrada de dados
            Console.Write("digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("digite a terceita nota: ");
            nota3 = float.Parse(Console.ReadLine());
        
            //processamento

            media = (nota1+nota2+nota3)/3;

            //resultado


            if(media>5){
                //valor verdadeiro
                Console.WriteLine("o aluno está aprovado");
                }else{
                    //valor falso
                    Console.WriteLine("o aluno esta reprovado");
                }
        }


    }
}
