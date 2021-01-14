using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome, civil;
            int idade;
            float salario;


            Console.WriteLine("Digite teu nome");
            nome = Console.ReadLine();

         
            Console.WriteLine("Digite tua idade");
            idade = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Digite teu salario");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite teu estado civil");
            civil = Console.ReadLine();


            while(string.IsNullOrEmpty(nome)){
            Console.WriteLine("Digite teu nome");
            nome = Console.ReadLine();


            }

            while(idade > 150 || idade < 0){
                    Console.WriteLine("Digite tua idade");
                    idade = int.Parse(Console.ReadLine());
                
            }

            while(salario < 0){
                    Console.WriteLine("Digite teu salario");
                    salario = float.Parse(Console.ReadLine());

                }

            while(civil != "s" && civil != "c" && civil != "v" && civil != "d"){
                
            Console.WriteLine("Digite teu estado civil");
            civil = Console.ReadLine();
            }
            
            
            Console.WriteLine("Nome: " + nome + " Idade: " + idade + " Salário: " + salario + " Estado Civil: " + civil);
        
        }
    }
}
