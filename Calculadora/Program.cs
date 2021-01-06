using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir a operaçao
            //pedir o 1º numero
            //pedir o 2º numero

            Console.WriteLine("digite a operaçao que deseja fazer \nSoma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine();


            Console.WriteLine("Digite o 1º numero");
            float num1 = float.Parse(Console.ReadLine());
        
              Console.WriteLine("Digite o 2º numero");
            float num2 = float.Parse(Console.ReadLine());


                     float resultado = 0;
                    // //if else/padrao
                    // if(operacao == "Soma"){
                    //         resultado = num1 + num2;


                    // }else if(operacao == "Subtracao)"){
                    //             resultado = num1 - num2;


                    // }else if(operacao == "Multiplicacao"){
                    //             resultado = num1 * num2;



                    // }else if(operacao == "Divisao"){
                    //                 resultado = num1 / num2;



                    // }else{
                    //     Console.WriteLine("operaçao invalida!");
                    // }


                    switch(operacao){
                        case "Soma":
                        resultado = num1+num2;
                            break;

                        case "Subtrair":
                        resultado = num1-num2;    
                            break;

                        
                        case "Multiplicar":
                        resultado = num1*num2;    
                            break;

                        
                        case "Dividir":
                        resultado = num1/num2;    
                            break;

                        default:
                        Console.WriteLine("operaçao invalida");
                        break;

                    }



                    // /concatenaçao
                     Console.WriteLine("Calculo : "+num1+" e "+num2+" = Resultado : " +resultado);


                    // //interpolaçao
                     Console.WriteLine($"Calculo: {num1} e {num2} = Resultado : {resultado}");
        
        }           

    }
}
