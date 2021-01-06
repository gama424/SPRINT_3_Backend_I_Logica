using System;

namespace projeto_maluco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("puta que pariu, 2 meses de curso e nos obrigam a fazer isso");
        
             string [] nomes = new string[5];
             string [] origem = new string[5];
             string [] destino = new string[5];
             string [] data = new string[5];

            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sistema de passagens aéreas");
            Console.WriteLine("-----------------------------");

            bool senhaValida;
            do
            {
                Console.WriteLine("Digite sua senha:");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
            } while (!senhaValida);

            //Criação do menu
            int escolha;
            do
            {
                Console.WriteLine("Menu principal");
                Console.WriteLine("Selecione uma opção válida:");
                Console.WriteLine("[1] Cadastrar Passagem");
                Console.WriteLine("[2] Listar Passagens Cadastradas");            
                Console.WriteLine("[0] Sair");
                escolha = int.Parse(Console.ReadLine());   

                switch (escolha)
                {
                    case 1:
                    //Cadastrar Passagem
                    string resposta;
                    int x =0;
                    Console.WriteLine("Atenção, você só pode cadastrar até 5 viagens");
                    Console.WriteLine("Caso tenha dúvidas em quantas já foram cadastradas, acesse o menu principal opção 2 \n 2- Listar Passagens Cadastradas, nessa opção as viagens não cadastradas estarão com os dados em branco");
                        for (var i = 0; i < 5; i = x)
                        {
                            Console.WriteLine($"Digite o nome do {i+1}º Passageiro");
                            nomes[i] = Console.ReadLine();
                            Console.WriteLine($"Digite a origem  do {i+1}º Passageiro");
                            origem[i] = Console.ReadLine();
                            Console.WriteLine($"Digite o destino  do {i+1}º Passageiro");
                            destino[i] = Console.ReadLine();
                            Console.WriteLine($"Digite a data da viagem do {i+1}º Passageiro");
                            data[i] = Console.ReadLine();

                            Console.WriteLine("Você gostaria de cadastrar outro passageiro? Responda apenas com Sim ou Não");
                            resposta = Console.ReadLine();
                                if(resposta == "Sim")
                                {
                                    x++;
                                    
                                }
                                else
                                {
                                    x=6;
                                }
                        }
                    break;
                    case 2:
                    //Listar passagens
                            Console.WriteLine("Lista de passagens já cadastradas:");
                            for (var i = 0; i < 5; i++)
                            {   
                                Console.WriteLine("-----------------------");
                                Console.WriteLine($"Nome do {i+1}º Passageiro : {nomes[i]}");
                                Console.WriteLine($"Origem: {origem[i]}");
                                Console.WriteLine($"Destino: {destino[i]}");
                                Console.WriteLine($"Data: {data[i]}");
                                Console.WriteLine("-----------------------");
                            }
                    break;
                    case 0:
                    //sair
                    break;
                    default:
                    break;
                }

            } while (escolha != 0);
                    

            //  lista de Funções
            // função login
            bool EfetuarLogin(string senha)
            {
                
                if(senha=="123456")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Senha incorreta");
                    return false;
                }
            
            // fim função;

            


            
    

        }