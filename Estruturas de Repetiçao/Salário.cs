using System;

namespace atividades
{
    class Salário
    {
        static void Main(string[] args)
        {
            
          float salario, reajuste;
        float porcentagem = (float)(100.0 * 0.30);
           
            Console.Write("digite seu salário: ");
            salario = float.Parse(Console.ReadLine());



            if(salario<=500){
                reajuste = salario + porcentagem;
                Console.Write("o seu salario foi reajustado para:" + reajuste);
            }
                else{
                    Console.Write("voce nao tem direito ao reajuste");
                }
        
        }
    }
}
