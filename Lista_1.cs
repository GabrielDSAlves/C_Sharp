using System;


namespace Lista_1
{
    internal class Program
    {

        static void EX12()
        {
            string Genero;
            double resultado, altura;

            Console.WriteLine("Este algoritimo ira calcular seu peso ideal\n\n");

            Console.Write("Entre com sua altura em metros: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Entre com a incial do seu genero h (Homem) ou m (Mulher): ");
            Genero = Console.ReadLine();

            Genero = Genero.ToUpper();
            if (Genero == "M")
            {
                resultado = (62.1 * altura) - 44.7;
                Console.WriteLine("\n\nO seu peso ideal sera: {0} KG", Math.Round(resultado));
            }

            if (Genero == "H")
            {
                resultado = (72.7 * altura) - 58;
                Console.WriteLine("\n\nO seu peso ideal sera: {0} KG", Math.Round(resultado));
            }

        }
                
        static void EX11()
        {
            double inicio = 1000.00, Porcentagem1=0.124, Porcentagem2=0.018, Porcentagem3=0.056, Porcentagem4=0.045, a, b, c, d;

            Console.WriteLine("investimentos do Marquesito");

            a = inicio * Porcentagem1;
            inicio = inicio - a;

            Console.WriteLine("\n\nPrimeiro dia de investimento = {0}", Math.Round(inicio, 3));

            b = inicio * Porcentagem2;
            inicio = inicio + b;

            Console.WriteLine("\n\nSegundo dia de investimento = {0}", Math.Round(inicio, 3));

            c = inicio * Porcentagem3;
            inicio = inicio + c;

            Console.WriteLine("\n\nTerceiro dia de investimento = {0}", Math.Round(inicio, 3));

            d = inicio * Porcentagem4;
            inicio = inicio - d;

            Console.WriteLine("\n\nQuarto dia de investimento = {0}", Math.Round(inicio, 3));

        }

        static void EX10()
        {
            int Numero, a, b, c, d;

            Console.Write("Entre com um numero inteiro de 4 digitos: ");
            Numero = int.Parse(Console.ReadLine());

            a = Numero % 10;
            Numero /= 10;
            b = Numero % 10;
            Numero /= 10;
            c = Numero % 10;
            Numero /= 10;
            d = Numero % 10;

            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
        }

        static void EX9()
        {
            int Numero, Sucessor, Antecessor;

            Console.Write("Entre com um numero inteiro: ");
            Numero = int.Parse(Console.ReadLine());

            Antecessor = (Numero * 3) - 1;
            Sucessor = (Numero * 2) + 1;

            Numero = Sucessor + Antecessor;

            Console.WriteLine("\n\nO Antecessor do triplo e igual a: {0}\nO sucessor do seu dobro e igual a: {1}\nA Soma deles e igual a: {2}", Antecessor, Sucessor, Numero);
        }

        static void EX8()
        {
            double Dolar, Real, r;

            Console.Write("Entre com um valor em real: ");
            Real = double.Parse(Console.ReadLine());

            Console.Write("Entre com a cotacao do dolar: ");
            Dolar = double.Parse(Console.ReadLine());

            r = Real / Dolar;

            Console.WriteLine("A sua conversao de real pra dolar e igual a: {0} dolar(es)", Math.Round(r, 3));
        }

        static void EX7()
        {
            double Salario, Novo_Salario, a = 0.337;

            Console.Write("Entre com seu salario atual: ");
            Salario = double.Parse(Console.ReadLine());

            a = a * Salario;

            Novo_Salario = Salario + a;

            Console.WriteLine("\n\nSeu novo salario sera de: {0}", Math.Round(Novo_Salario, 3));

        }

        static void EX6()
        {
            /*A primeira lei de Newton é o princípio da Inércia.
             * Segundo ela, um corpo tende a continuar em repouso desde que
             * uma força atue sobre ele. A segunda lei de Newton é considerada o 
             * princípio fundamental da dinâmica. A lei diz
             * que uma força é sempre proporcional ao produto da massa pela aceleração. Ou seja: F = m.a*/


            //F = força resultante (medida em newtons (N))
            //m = massa do corpo (medida em kg) 
            //a = aceleração (medida em metro por segundo ao quadrado m/s²).

            double F, m, a;

            Console.WriteLine("A formula sera: F = m.a\n\n");
            Console.Write("Entre com o valor da massa do corpo em kilos (m): ");
            m = double.Parse(Console.ReadLine());

            Console.Write("\nEntre com o valor da aceleracao (a): ");
            a = double.Parse(Console.ReadLine());

            F = m * a;

            Console.WriteLine("\n\nO valor da força resultado sera de: {0}", Math.Round(F, 3));
        }

        static void EX5()
        {
            double Nota1, Nota2, Nota3, Peso1, Peso2, Peso3, Media_Ponderada;

            Console.Write("Entre com a primeira Nota: ");
            Nota1 = double.Parse(Console.ReadLine());
     
            Console.Write("\nEntre com o peso da primeira nota: ");
            Peso1 = double.Parse(Console.ReadLine());

            Console.Write("\n\nEntre com a segunda Nota: ");
            Nota2 = double.Parse(Console.ReadLine());

            Console.Write("\nEntre com o peso da segunda nota: ");
            Peso2 = double.Parse(Console.ReadLine());

            Console.Write("\n\nEntre com a terceira Nota: ");
            Nota3 = double.Parse(Console.ReadLine());

            Console.Write("\nEntre com o peso da terceira nota: ");
            Peso3 = double.Parse(Console.ReadLine());

            Media_Ponderada = (Peso1 * Nota1 + Peso2 * Nota2 + Peso3 * Nota3)/ (Peso1 + Peso2 + Peso3);

            Console.WriteLine("\n\nA media ponderada tem o valor: {0}", Math.Round(Media_Ponderada, 3));
        }

        static void EX4()
        {
            double Altura, Peso, IMC;

            Console.Write("Entre com sua altura em metros: ");
            Altura = double.Parse(Console.ReadLine());

            Console.Write("\nEntre com seu peso: ");
            Peso = double.Parse(Console.ReadLine());

            IMC = Peso / (Altura * Altura);

            Console.WriteLine("\nSeu IMC sera: {0}", Math.Round(IMC, 3));

            Console.WriteLine("\n\n");
            if(IMC < 18.5)
                Console.WriteLine("Peso abaixo do normal");
           
            if ((IMC > 18.5) && (IMC < 25))
                Console.WriteLine("Peso normal");
            
            if ((IMC > 25) && (IMC < 30))
                Console.WriteLine("Sobrepeso");

            if ((IMC > 30) && (IMC < 40))
                Console.WriteLine("Obesidade");

            if (IMC > 40)
                Console.WriteLine("Obesidade Grave");
            
        }

        static void EX3()
        {
            double f, c;
            float F, C;
            int escolha, far, cel;

            Console.Write("Escolha o tipo da variavel\n1- Float\n2- Double\n3- Int\n\nEscolha: ");
            escolha = int.Parse(Console.ReadLine());

            Console.Write("\n\nEntre com um valor da tempuratura em Fahrenheit: ");

            if (escolha == 1)
            {
                F = float.Parse(Console.ReadLine());
                C = (F - 32.0f) * (5.0f / 9.0f);
                Console.WriteLine("\n\nA temperatura em Celsius sera: {0:f3}", C);
            }

            if (escolha == 2)
            { 
                f = double.Parse(Console.ReadLine());
                c = (f - 32.0) * (5.0 / 9.0);
                Console.WriteLine("\n\nA temperatura em Celsius sera: {0}", Math.Round(c,3));
            }

            if(escolha == 3)
            {
                far = int.Parse(Console.ReadLine());
                cel = (far - 32) * (5/ 9);
                Console.WriteLine("\n\nA Temperatura em celsius sera: {0}", cel);
            }

        }

        static void EX2()
        {
            float Metros, Centimetros, Milimetros;

            Console.Write("Entre com um valor em metros: ");
            Metros = float.Parse(Console.ReadLine());

            Centimetros = Metros * 100;
            Milimetros = Metros * 1000;

            Console.WriteLine("\n\nO valor {0} convertido em Centimetros sera: {1:f2}", Metros, Centimetros);
            Console.WriteLine("O valor {0} convertido em Milimetros sera: {1:f2}", Metros, Milimetros);
        }

        static void EX1()
        {
            double Res, SalarioMinimo, Salario, INSS = 0.085;

            Console.Write("Entre com o salario minimo atual: ");
            SalarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Entre com o seu salario atual: ");
            Salario = double.Parse(Console.ReadLine());

            INSS = Salario * INSS;

            Res = Salario - INSS;

            Res = Res / SalarioMinimo;



            Console.WriteLine("\n\nVoce recebe {0} o salario minimo", Math.Round(Res, 3));
        }

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("   Gabriel David dos Santos Alves    ");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("            Menu Lista 1             ");
            Console.WriteLine("_____________________________________\n");

            Console.WriteLine("====================================");
            Console.WriteLine("0- SAIR.............................");
            Console.WriteLine("1- Exercicio........................");
            Console.WriteLine("2- Exercicio........................");
            Console.WriteLine("3- Exercicio........................");
            Console.WriteLine("4- Exercicio........................");
            Console.WriteLine("5- Exercicio........................");
            Console.WriteLine("6- Exercicio........................");
            Console.WriteLine("7- Exercicio........................");
            Console.WriteLine("8- Exercicio........................");
            Console.WriteLine("9- Exercicio........................");
            Console.WriteLine("10- Exercicio.......................");
            Console.WriteLine("11- Exercicio.......................");
            Console.WriteLine("12- Exercicio.......................");
            Console.WriteLine("====================================");

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
                switch(opcao)
                {
                    case 0: Console.WriteLine("Obrigado por usar o sistema!!!");
                        Console.ReadKey();
                        break;
                    case 1: EX1();
                        Console.ReadKey();
                        break;
                    case 2: EX2();
                        Console.ReadLine();
                        break;
                    case 3: EX3();
                        Console.ReadLine();
                        break;
                    case 4: EX4();
                        Console.ReadLine();
                        break;
                    case 5: EX5();
                        Console.ReadLine();
                        break;
                   case 6: EX6();
                        Console.ReadLine();
                        break;
                    case 7: EX7();
                        Console.ReadLine();
                        break;
                    case 8 : EX8();
                        Console.ReadLine();
                        break;
                    case 9: EX9();
                        Console.ReadLine();
                        break;
                    case 10: EX10();
                        Console.ReadLine();
                        break;
                    case 11: EX11();
                        Console.ReadLine();
                        break;
                    case 12: EX12();
                        Console.ReadLine();
                        break;
                   default: Console.WriteLine("Opcao invalida!");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 0);


            
        }
    }
}
