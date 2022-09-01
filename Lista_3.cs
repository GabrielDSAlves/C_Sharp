using System;

namespace Lista_3
{
    internal class Program
    {
        static void EX6()
        {
            int numero, i, j;
            char caracter;

            Console.Write("Entre com a quantidade de linhas do triangulo: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Enter com um caracter que sera impresso no triangulo: ");
            caracter = char.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for (i = 1; i <= numero; i++)
            {
                for (j = 0; j < numero; j++)
                    Console.Write("");
                for (j = 0; j < i; j++)
                    Console.Write(caracter);

                Console.WriteLine();
            }
        }

        static void EX5()
        {
            int P, contador = 0;

            Console.Write("Entre com o valor de P: ");
            P = int.Parse(Console.ReadLine());

            while (contador <= P * P)
            {
                if ((contador % 3 == 0) && (contador % 6 != 0) && (contador %2 == 1))
                    Console.Write(contador + "\n");
                
                contador += 1;
            }        
        }

        static void EX4()
        {
            Random NumAleatorio = new Random();
            int i, pares = 0, impares = 0, numero;

            Console.WriteLine("Este programa ira apresentar 97 numeros aleatorios e inteiros e no final ira mostra a soma dos numeros pares e impares\n\n\n");
            for (i = 0; i < 97; i++)
            {
                numero = NumAleatorio.Next(0, 100);
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"numero {i + 1} = {numero} | O numero {numero} e par\n");
                    pares += numero;
                }
                else if (numero % 2 == 1)
                {
                    Console.WriteLine($"numero {i + 1} = {numero} | O numero {numero} e impar\n");
                    impares += numero;
                }
            }
            Console.WriteLine($"\n\nSoma dos impares = {impares}\nSoma dos pares = {pares}");
        }

        static void EX3()
        {
            int X, Y;

            Console.WriteLine("Entre com dois numeros X e Y, considerando o intervalo entre eles\n");

            Console.Write("Entre com o valor de Y: ");
            Y = int.Parse(Console.ReadLine());

            Console.Write("Entre com o valor de X: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = Y; i <= X; i++)
            {
                if (i % 7 == 3)
                    Console.WriteLine($"O numero {i} divisivel por 7 tem o resto igual a 3");
                else if (i % 7 != 3)
                    Console.WriteLine($"Numero {i} nao tem resto igual a 3");
            }
        }

        static void EX2()
        {
            int i = 0 ;
            double numero = 0, soma = 0 , media = 0;

            Console.WriteLine("Entre com numeros ou aperte <0> para finalizar o programa.....");

            do
            {
                soma += numero;
                i++;
                Console.Write($"\nNumero {i} = ");
                numero = double.Parse(Console.ReadLine());
                

            } while(numero != 0);

            media = soma / (i - 1);
            Console.WriteLine($"\n\nA soma dos numeros digitados: {Math.Round(soma, 3)}\nA media dos numeros digitados: {Math.Round(media, 3)}");
        }

        static void EX1()
        {

            double maior = 0, menor = 0, media = 0, numero, soma = 0;
            Random NumAleatorio = new Random();


            Console.WriteLine("sera impresso 213 numeros e sera apresentado o menor e o maior entre eles e sua media\n");
            for (int i = 0; i < 213; i++)
            {
                numero = NumAleatorio.NextDouble() * 100;

                Console.Write($"\nnumero {i +1} = {Math.Round(numero, 3)}");

                if (i == 0)
                {
                    maior = numero;
                    menor = numero;
                }
                if (numero > maior)
                    maior = numero;
                
                if (numero < menor)
                    menor = numero;
                
                soma += numero;
            }
            media =soma /  213;
            Console.WriteLine($"\n\nSoma:{Math.Round(soma, 3)}\nMédia: {Math.Round(media, 3)}\nMaior: {Math.Round(maior, 3)}\nMenor: {Math.Round(menor, 3)}");
        }

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("   Gabriel David dos Santos Alves    ");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("            Menu Lista 3             ");
            Console.WriteLine("_____________________________________\n");

            Console.WriteLine("======================================");
            Console.WriteLine("0- SAIR.............................");
            Console.WriteLine("1- Exercicio........................");
            Console.WriteLine("2- Exercicio........................");
            Console.WriteLine("3- Exercicio........................");
            Console.WriteLine("4- Exercicio........................");
            Console.WriteLine("5- Exercicio........................");
            Console.WriteLine("6- Exercicio........................");
;
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
                        EX1();
                        Console.ReadKey();
                        break;
                    case 2:
                        EX2();
                        Console.ReadLine();
                        break;
                    case 3:
                        EX3();
                        Console.ReadLine();
                        break;
                    case 4:
                        EX4();
                        Console.ReadLine();
                        break;
                    case 5:
                        EX5();
                        Console.ReadLine();
                        break;
                    case 6:
                        EX6();
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
