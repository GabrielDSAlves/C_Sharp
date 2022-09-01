using System;


namespace Lista_2
{
    internal class Program
    {
        static void EXK()
        {
            double VENDA, COMISSAO;

            Console.Write("Entre com o valor das vendas: R$");
            VENDA = double.Parse(Console.ReadLine());

            if (VENDA >= 100000.00)
            { 
                COMISSAO = 700 + (VENDA * 0.16);
                Console.WriteLine("\n\nSua comissao sera de: {0}", Math.Round(COMISSAO, 3));
            }
            else if (VENDA >= 80000.00)
            { 
                COMISSAO = 650 + (VENDA * 0.14);
                Console.WriteLine("\n\nSua comissao sera de: {0}", Math.Round(COMISSAO, 3));
            }
            else if (VENDA >= 60000.00)
            { 
                COMISSAO = 600 + (VENDA * 0.14);
                Console.WriteLine("\n\nSua comissao sera de: {0}", Math.Round(COMISSAO, 3));
            }
            else if (VENDA >= 40000.00)
            { 
            COMISSAO = 550 + (VENDA * 0.14);
            Console.WriteLine("\n\nSua comissao sera de: {0}", Math.Round(COMISSAO, 3));
            } 
            else if (VENDA >= 20000.00)
            { 
                COMISSAO = 500 + (VENDA * 0.14);
                Console.WriteLine("\n\nSua comissao sera de: {0}", Math.Round(COMISSAO, 3));
            }
            else if (VENDA < 20000.00)
            {
                COMISSAO = 400 + (VENDA * 0.14);
                Console.WriteLine("\n\nSua comissao sera de: {0}", Math.Round(COMISSAO, 3));
            }

        }

        static void EXJ()
        {
            int NUMERO1, NUMERO2, NUMERO3, R;
            string OPCAO;

            Console.Write("Entre com o primeiro numero: ");
            NUMERO1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo numero: ");
            NUMERO2 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o terceiro numero: ");
            NUMERO3 = int.Parse(Console.ReadLine());

            if ((NUMERO1 < 0) || (NUMERO2 < 0) || (NUMERO3 < 0))
                Console.WriteLine("\n\nErro: Entre com numeros positivos");
            else
            {
                Console.Write("\n\nEscolha o calculo de alguma media\n\nA- Ponderada\nB- Harmonica\nC- Aritimetica\n\nSua escolha: ");
                OPCAO = Console.ReadLine();
                OPCAO = OPCAO.ToUpper();

                Console.Clear();
                if (OPCAO == "A")
                {
                    R = (NUMERO1 + 2 * NUMERO2 + 3 * NUMERO3) / 6;
                    Console.WriteLine("======== RESULTADO =======");
                    Console.WriteLine("\n\n({0} + 2 x {1} + 3 x {2} / 6 = {3}", NUMERO1, NUMERO2, NUMERO3, R);
                }
                else if (OPCAO == "B")
                {
                     R = (int)(1 / ((1 / (float)NUMERO1) + (1 / (float)NUMERO2) + (1 / (float)NUMERO3)));

                    Console.WriteLine("======== RESULTADO =======");
                    Console.WriteLine("\n\n1 / ((1 / {0}) + (1 / {1}) + (1 / {2}) = {3}", NUMERO1, NUMERO2, NUMERO3, R);
                                      
                }
                else if (OPCAO == "C")
                {
                    R = (NUMERO1 + NUMERO2 + NUMERO3) / 3;
                    Console.WriteLine("======== RESULTADO =======");
                    Console.WriteLine("\n\n({0} + {1} + {2}) / 3 = {3}", NUMERO1, NUMERO2, NUMERO3, R);
                }
                else
                    Console.WriteLine("ERRO: Opcao invalida!");
            }
        }

        static void EXI()
        {
            double CONSUMO, KM, CONSUMO_KM;

            Console.Write("Entre com a distancia em percorrida em KM: ");
            KM = double.Parse(Console.ReadLine());

            Console.Write("Entre com o Consumo do percurso em litros: " );
            CONSUMO = double.Parse(Console.ReadLine());

            CONSUMO_KM = KM / CONSUMO;

            if (CONSUMO_KM < 8)
                Console.WriteLine("\n\nVenda o carro ou compre um posto!");
            else if (CONSUMO_KM < 14)
                Console.WriteLine("\n\nEconômico!");
            else 
                Console.WriteLine("\n\nSuper econômico!");
        }

        static void EXH()
        {
            int NUMERO;

            Console.WriteLine("Verificando se o numero inteiro e divisivel por 3 ou por 5 mas nao simultaneamente...\n\n");
        
            Console.Write("Entre com um numero inteiro: ");
            NUMERO = int.Parse(Console.ReadLine());


            if ((NUMERO % 3 == 0) && (NUMERO % 5 == 0))
                Console.WriteLine("\n\nErro: Tente outro numero");
            else if (NUMERO % 5 == 0)
                Console.WriteLine("\n\nSeu numero e divisivel por 5!");
            else if (NUMERO % 3 == 0)
                Console.WriteLine("\n\nSeu numero e divisivel por 3!");
            else
                Console.WriteLine("\n\nSeu numero nao e divisivel por nenhum dos numeros citados acima...");
        }

        static void EXG()
        {
            int OPCAO;
            double VALOR1, VALOR2, RESULTADO;

            do
            {
                Console.Clear();
                Console.Write("Escolha a operacao desejada\n\n0- SAIR\n1- SOMA\n2- SUBTRACAO\n3- MULTIPLICACAO\n4- DIVISAO\n\nSua escolha: ");
                OPCAO = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (OPCAO)
                {
                    case 0:
                        Console.WriteLine("\n\nRetornando ao menu!");
                        break;
                    case 1:
                        Console.WriteLine("ADICAO");

                        Console.Write("\n\nEntre com o primeiro valor: ");
                        VALOR1 = double.Parse(Console.ReadLine());

                        Console.Write("Entre com o segundo valor: ");
                        VALOR2 = double.Parse(Console.ReadLine());

                        RESULTADO = VALOR1 + VALOR2;

                        Console.WriteLine("\n\n{0} + {1} = {2}", Math.Round(VALOR1, 3), Math.Round(VALOR2, 3), Math.Round(RESULTADO, 3));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("SUBTRACAO");

                        Console.Write("\n\nEntre com o primeiro valor: ");
                        VALOR1 = double.Parse(Console.ReadLine());

                        Console.Write("Entre com o segundo valor: ");
                        VALOR2 = double.Parse(Console.ReadLine());

                        RESULTADO = VALOR1 - VALOR2;

                        Console.WriteLine("\n\n{0} - {1} = {2}", Math.Round(VALOR1, 3), Math.Round(VALOR2, 3), Math.Round(RESULTADO, 3));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("MULTIPLICACAO");

                        Console.Write("\n\nEntre com o primeiro valor: ");
                        VALOR1 = double.Parse(Console.ReadLine());

                        Console.Write("Entre com o segundo valor: ");
                        VALOR2 = double.Parse(Console.ReadLine());

                        RESULTADO = VALOR1 * VALOR2;

                        Console.WriteLine("\n\n{0} X {1} = {2}", Math.Round(VALOR1, 3), Math.Round(VALOR2, 3), Math.Round(RESULTADO, 3));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("DIVISAO");

                        Console.Write("\n\nEntre com o primeiro valor: ");
                        VALOR1 = double.Parse(Console.ReadLine());

                        Console.Write("Entre com o segundo valor: ");
                        VALOR2 = double.Parse(Console.ReadLine());

                        RESULTADO = VALOR1 / VALOR2;

                        Console.WriteLine("\n\n{0} / {1} = {2}", Math.Round(VALOR1, 3), Math.Round(VALOR2, 3), Math.Round(RESULTADO, 3));
                        Console.ReadKey();
                        break;
                    default: Console.WriteLine("Opcao invalida!");
                        Console.ReadKey();
                        break;
                }

            } while (OPCAO != 0);
        }

        static void EXF()
        {
            int dia;
          
            do
            {
                Console.Clear();
                Console.Write("Entre com um numero correpondente ao dia da Semana\n\n0- SAIR.....\n1- DOMINGO.....\n2- SEGUNDA.....\n3- TERCA....." +
               "\n4- QUARTA..... \n5- QUINTA.....\n6- SEXTA.....\n7- SABADO.....\n\nSua escolha: ");
                dia = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (dia)
                {
                    case 0:
                        Console.WriteLine("Voltando para o menu...");
                        break;
                    case 1:
                        Console.WriteLine("\n\nDomingo!");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\n\nSegunda!");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\n\nTerca!");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\n\nQuarta!");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\n\nQuinta!");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("\n\nSexta!");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("\n\nSabado!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\n\nOpcao invalida!");
                        Console.ReadKey();
                        break;
                }
            }while (dia != 0);
        }

        static void EXE()
        {
            int NUMERO1, NUMERO2, X;

            Console.Write("Entre com o primeiro numero: ");
            NUMERO1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo numero: ");
            NUMERO2 = int.Parse(Console.ReadLine());

            if (NUMERO1 > NUMERO2)
            {
                X = NUMERO1;
                NUMERO1 = NUMERO2;
                NUMERO2 = X;
                Console.Write("\n\nO numero {0} é maior", NUMERO2);
            }
            else if (NUMERO2 > NUMERO1)
            {
                Console.WriteLine("\n\nO numero {0} é maior", NUMERO2);
            }
            else if (NUMERO1 == NUMERO2)
                Console.WriteLine("\n\nNumero iguais!");

            
        }

        static void EXD()
        {
            double N;

            Console.Write("Entre com um numero par e positivo: ");
            N = double.Parse(Console.ReadLine());
            

            if((N % 2 == 0) && (N >=0))
            {
                N = Math.Sqrt(N);
                Console.Write("\n\nA raiz quadrada do seu numero sera: {0}", N);
            }
            else
                Console.WriteLine("\n\nNumero incopativel. Tente colocar um numero positivo e par");
            
                
        }
        
        static void EXC()
        {
            double A, B, H;

            Console.Write("Entre com o primeiro valor do primeiro cateto: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Entre com o valor do segundo cateto: ");
            B = double.Parse(Console.ReadLine());

            H = Math.Sqrt(A * A + B * B);

            Console.WriteLine("\n\nSua hipotenusa sera: {0}", Math.Round(H, 2));
        }

        static void EXB()
        {
            double PI = 3.1415926535, R, G;

            Console.Write("Entre com um angulo em radiano: ");
            R = double.Parse(Console.ReadLine());

            G = R * 180 / PI;

            Console.WriteLine("\n\nSeu angulo convertido em graus sera: {0}", Math.Round(G, 3));
        }

        static void EXA()
        {
            int Numero1, Numero2, Numero3, x;

            Console.Write("Entre com o primeiro numero: ");
            Numero1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo numero: ");
            Numero2 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o terceiro numero: ");
            Numero3 = int.Parse(Console.ReadLine());

            if (Numero2 < Numero1)
            {
                x = Numero1;
                Numero1 = Numero2;
                Numero2 = x;
            }
            else if (Numero3 < Numero1)
            {
                x = Numero1;
                Numero1 = Numero3;
                Numero3 = x;
            }
            else if (Numero3 < Numero2)
            {
                x = Numero2;
                Numero2 = Numero3;
                Numero3 = x;
            }

            Console.Write("\n\nOs numero inseridos, em ordem ficara: {0}, {1} e {2}", Numero1, Numero2, Numero3);

        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("   Gabriel David dos Santos Alves    ");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("            Menu Lista 2             ");
            Console.WriteLine("_____________________________________\n");

            Console.WriteLine("======================================");
            Console.WriteLine("0- SAIR...............................");
            Console.WriteLine("1- Exercicio A........................");
            Console.WriteLine("2- Exercicio B........................");
            Console.WriteLine("3- Exercicio C........................");
            Console.WriteLine("4- Exercicio D........................");
            Console.WriteLine("5- Exercicio E........................");
            Console.WriteLine("6- Exercicio F........................");
            Console.WriteLine("7- Exercicio G........................");
            Console.WriteLine("8- Exercicio H........................");
            Console.WriteLine("9- Exercicio I........................");
            Console.WriteLine("10- Exercicio J.......................");
            Console.WriteLine("11- Exercicio K.......................");
            Console.WriteLine("======================================");

            Console.Write("\n\nEscolha um Exercicio para executar: ");

            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                opcao = Menu();
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar o sistema!!!");
                        Console.ReadKey();
                        break;
                    case 1:
                        EXA();
                        Console.ReadKey();
                        break;
                    case 2:
                        EXB();
                        Console.ReadLine();
                        break;
                    case 3:
                        EXC();
                        Console.ReadLine();
                        break;
                    case 4:
                        EXD();
                        Console.ReadLine();
                        break;
                    case 5:
                        EXE();
                        Console.ReadLine();
                        break;
                    case 6:
                        EXF();
                        Console.ReadLine();
                        break;
                    case 7:
                        EXG();
                        Console.ReadLine();
                        break;
                    case 8:
                        EXH();
                        Console.ReadLine();
                        break;
                    case 9:
                        EXI();
                        Console.ReadLine();
                        break;
                    case 10:
                        EXJ();
                        Console.ReadLine();
                        break;
                    case 11:
                        EXK();
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 0);
        }
    }
}
