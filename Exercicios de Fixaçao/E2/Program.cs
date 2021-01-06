using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gasosa");

            Console.WriteLine("selecione um tipo de combustivel");
            Console.WriteLine("A- Alcool");
            Console.WriteLine("G- Gasosa");
            string combustivel = Console.ReadLine();

            Console.WriteLine("digite a quantidade de combustivel");
            float quantidadeCombustivel = float.Parse(Console.ReadLine());


            float percDesconto, desconto, valorTotal;
            float precoAlcool = 4f;
            float precoGasosa = 5f;

            switch (combustivel.ToLower())
            {
                case "a":
                    if(quantidadeCombustivel>20){
                        percDesconto = 0.05f;
                    }else{
                        percDesconto = 0.03f;
                    }

                    
                    
                    valorTotal = (quantidadeCombustivel * precoAlcool);
                    desconto = (quantidadeCombustivel * precoAlcool)* percDesconto;
                    Console.WriteLine($"valor a ser pago{valorTotal-desconto}");
                   
                    break;

                    case "g":
                    if(quantidadeCombustivel>20){
                        percDesconto = 0.6f;

                    }else{
                        percDesconto = 0.04f;

                    }
                    valorTotal = (quantidadeCombustivel * precoGasosa);
                    desconto = (quantidadeCombustivel * precoGasosa) * percDesconto;
                    Console.WriteLine($"valor a ser pago{valorTotal-desconto}");
                    break;

                default:
                Console.WriteLine("opçao invalida");
                    break;
            }
            

            float AplicarDesconto(float litros, float preco, float perc1, float perc2){
                if(litros>20){
                    float valorTotal = litros * preco;
                    float desconto = (litros* preco)* perc1
                    return valorTotal - desconto;

                }else{
                    float valorTotal = litros * preco;
                    float desconto = (litros* preco)* perc2
                    return valorTotal - desconto;
                }
            }

        }
    }
}
