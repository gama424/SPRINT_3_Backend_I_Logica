using System;

namespace funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("que tarefa do caralho hein");
            
        
// Váriaveis declaradas
            string[] nomes = new string[4];
            float [] media = new float[4];
            float [] notas = new float[4]; 
            float [] aprovado = new float[4];

            // Laço de repetição para o array de nomes e notas
            for(int contador = 0; contador < 4; contador++){

                Console.WriteLine("Digite o nome do aluno: ");
                nomes[contador] = Console.ReadLine();

                for (var cont = 0; cont < 4; cont++)
                {
                    Console.WriteLine("Digite a "+(cont+1)+"° nota: ");
                    notas[cont] = float.Parse(Console.ReadLine());
                }
            // Entrando na função CalcularMedia
                media[contador] = CalcularMedia(notas);  
                aprovado[contador] = QtdAprovados(media);             

            }

            // Exibindo o nome e a média de cada aluno
            for (var cnt = 0; cnt < nomes.Length ; cnt++)
            {
                Console.WriteLine($"Nome : {nomes[cnt]} - Média : {media[cnt]} ");

            }  

            foreach(float aprov in aprovado){
            Console.WriteLine($"Total aprovados: {aprov} ");
            }
        }

        // Função CalcularMedia
        static float CalcularMedia(float[] numeros){

        // Variavel declarada
            float soma = 0;

        // Laço de repetição da soma
            for (var contador = 0; contador < numeros.Length; contador++)
            {
                soma += numeros[contador];
            }

        // Variavel de calculo
            float calculo = soma / numeros.Length;

        // Retornar a variavel calculo para a função Main(Principal)
            return calculo;
        }

        // Função QtdAprovados
        static float QtdAprovados(float[] media){
            float quant = 0;

                if(media.Length >= 7){
                    quant++;
                }
               

            return quant;
        }



        }
    }

