using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menção_Prog.Alg._01
{
    internal class Program
    {
        static void Main(string[] 
            args)
        {
            Console.WriteLine("Exercício 1: Escreva um programa que armazene em variáveis o seu nome, sua idade e a cidade onde reside. Na sequencia exiba o conteúdo destas variáveis na tela.");

            string nome;
            string cidade;
            int idade;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cidade em que voce mora:");
            cidade = Console.ReadLine();
            Console.WriteLine("Seu nome é:" + nome + " você tem " + idade + " anos e mora em " + cidade);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX");

            Console.WriteLine("Exercício 2: Escreva um programa que leia um número inteiro, calcule e exiba o resultado do dobro deste número.");

            int numero, resultado;


            Console.WriteLine("Digite um numero:");
            numero = int.Parse(Console.ReadLine());
            resultado = +numero * 2;
            Console.WriteLine("O dobro de: " + numero + " é: " + resultado);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX");

            Console.WriteLine("Exercício 3: Escreva um programa que leia um número inteiro, calcule e exiba o resultado do quadrado deste número. (usar função da classe Math)");

            double numero2;
            double resultado2;
            Console.WriteLine("Digite um numero:");
            numero2 = double.Parse(Console.ReadLine());
            resultado2 = Math.Pow(+numero2, 2);
            Console.WriteLine("O quadrado de: " + numero2 + " é igual a: " + resultado2);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX");

            Console.WriteLine("Exercício 4: Escreva um programa que calcule e exiba o resultado da seguinte expressão matemática: (Dica: O usuário deverá informar os valores para as variáveis A, B e C) A² * 5 – C / (B – A % 4)");

            double A;
            double B;
            double C;
            double resultado3;

            Console.WriteLine("Digite o valor de A:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            C = double.Parse(Console.ReadLine());
            resultado3 = +A * +A * 5 - +C / (+B - +A % 4);
            Console.WriteLine("O resultado da expressão A² * 5 – C / (B – A % 4) é: " + resultado3);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX");

            Console.WriteLine("Exercício 5: Escreva um programa que leia a idade de uma pessoa e deverá ser exibido na tela, se esta pessoa é maior ou menor de idade (considerar 18 anos para maior idade).");

            int idade2;

            Console.WriteLine("Quantos anos você tem ?");
            idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você é: " + (idade2 >= 18 ? "Maior de idade." : "Menor de Idade"));
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX");

            Console.WriteLine("Exercício 6: Escreva um programa que leia um valor em Reais (R$), leia também a cotação do Dólar, realize o cálculo da conversão de moeda (de Reais para Dólares) e exiba na tela o resultado.");

            double Valor;
            double resultado4;
            double Dolar;

            Console.WriteLine("Digite um valor de dinheiro em reais:");
            Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cotação do Dolar:");
            Dolar = double.Parse(Console.ReadLine());
            resultado4 = +Valor / +Dolar;
            Console.WriteLine("O valor de " + Valor + " em Dolar é: " + resultado4);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX");

            Console.WriteLine("Exercício 7: Escreva um programa que leia o nome de duas pessoas e ao final exiba: •	O nome das duas pessoas com todos os caracteres maiúsculos •	A quantidade de caracteres de cada nome •	Apenas os três primeiros caracteres de cada nome");

            string nome1;
            string nome2;

            Console.WriteLine("Digite um nome:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite outro nome:");
            nome2 = Console.ReadLine();
            Console.WriteLine(nome1 + " em maiúsculo é: " + nome1.ToUpper());
            Console.WriteLine(nome2 + " em maiúsculo é: " + nome2.ToUpper());
            Console.WriteLine(nome1 + " tem " + nome1.Length + " letras");
            Console.WriteLine(nome2 + " tem " + nome2.Length + " letras");
            Console.WriteLine("as três primeiras letras de " + nome1 + " são: " + nome1.Substring(0, 3));
            Console.WriteLine("as três primeiras letras de " + nome2 + " são: " + nome2.Substring(0, 3));
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX");

            Console.WriteLine("Exercício 8: Escreva um programa que leia um valor em Reais (R$), leia também a cotação do Dólar e do Euro, realize o cálculo das respectivas conversões de moedas (de Reais para Dólares e de Reais para Euros) e exiba os resultados na tela.");

            double Valor1;
            double Dolar1;
            double Euro1;
            double resultadoDolar;
            double resultadoEuro;

            Console.WriteLine("Digite um valor de dinheiro em reais:");
            Valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cotação do Dolar:");
            Dolar1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cotação do Euro:");
            Euro1 = double.Parse(Console.ReadLine());
            resultadoDolar = +Valor1 / +Dolar1;
            resultadoEuro = +Valor1 / +Euro1;
            Console.WriteLine("O valor de " + Valor1 + " em Dolar é: " + resultadoDolar);
            Console.WriteLine("O valor de " + Valor1 + " em Euro é: " + resultadoEuro);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX");

            Console.WriteLine("Exercício 9: Escreva um programa que leia dois números inteiros, sendo armazenados respectivamente nas variáveis A e B. O programa deverá inverter os valores entre as variáveis, de modo que o valor da variável A seja atribuído na variável B e vice-versa. Ao final exibir os valores de cada variável.");

            int a;
            int b;
            int c;

            Console.WriteLine("Digite o valor de a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b:");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("O valor de 'a' é: " + a + " e o valor de 'b' é: " + b);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX");

            Console.WriteLine("Exercício 10: Escreva um programa que calcule a expressão lógica, sendo que o usuário deverá informar os valores (números inteiros) para as variáveis. ((X >= Y) AND (Z <=X)) OR ((X == W) AND (Y == Z)) OR (NOT(X != W))");

            int X;
            int Y;
            int W;
            int Z;
            bool resposta;

            Console.WriteLine("Digite o valor de X:");
            W = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y:");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de W:");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Z:");
            Z = int.Parse(Console.ReadLine());
            resposta = ((+X >= +Y) && (+Z <= +X)) || ((+X == +W) && (+Y == +Z)) || (!(+X != +W));
            Console.WriteLine("O resultado da expressão ((X >= Y) AND (Z <=X)) OR ((X == W) AND (Y == Z)) OR (NOT(X != W)) é:" + resposta);
            Console.ReadKey();
        }
    }
}





        