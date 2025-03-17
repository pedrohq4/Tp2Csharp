using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 1
            Console.WriteLine("Digite sua data de nascimento (formato: dd/MM/yyyy):");
            string idadestr = Console.ReadLine();

            DateTime.TryParseExact(idadestr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataNascimento);
            DateTime dataAtual = DateTime.Today;

            int anos = dataAtual.Year - dataNascimento.Year;
            int meses = dataAtual.Month - dataNascimento.Month;
            int dias = dataAtual.Day - dataNascimento.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"Você tem: {anos} anos, {meses} meses e {dias} dias.");
            */




            /*Exercício 2

            Console.WriteLine("Digite sua data de nascimento (formato: dd/MM/yyyy):");
            string datastr = Console.ReadLine();


            DateTime.TryParseExact(datastr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataNascimento);
            DateTime dataAtual = DateTime.Today;

            DateTime proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

            if (proximoAniversario < dataAtual)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            TimeSpan diferenca = proximoAniversario - dataAtual;
            int diasRestantes = diferenca.Days;

            Console.WriteLine($"Faltam {diasRestantes} dias para o seu aniversário.");
            */




            /*Exercício 3
            Console.WriteLine("Digite a primeira data (formato: dd/MM/yyyy):");
            string datastr1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda data (formato: dd/MM/yyyy):");
            string datastr2 = Console.ReadLine();

            DateTime.TryParseExact(datastr1, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data1);
            DateTime.TryParseExact(datastr2, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data2);

            int anos = data2.Year - data1.Year;
            int meses = data2.Month - data1.Month;
            int dias = data2.Day - data1.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(data2.Year, data2.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"Diferença entre as datas: {anos} anos, {meses} meses e {dias} dias.");
            */




            /*Exercício 4

            Console.WriteLine("Digite seu nome.");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu idade.");
            int.TryParse(Console.ReadLine(), out int idade);

            Console.WriteLine("Digite seu telefone.");
            int.TryParse(Console.ReadLine(), out int telefone);

            Console.WriteLine("Digite seu email.");
            string email = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Idade: {idade}, Telefone: {telefone}, Email: {email}");
            */

            /*Exercício 5 
            Console.WriteLine("Digite a temperatura em graus Celsius:");
            double.TryParse(Console.ReadLine(), out double celsius);

            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"{celsius}°C");
            Console.WriteLine($"{fahrenheit}°F");
            Console.WriteLine($"{kelvin}K");
            */




            /*Exercicio 6
            string classificacao;

            Console.WriteLine("Digite seu peso em kg:");
            double.TryParse(Console.ReadLine(), out double peso);

            Console.WriteLine("Digite sua altura em metros:");
            double.TryParse(Console.ReadLine(), out double altura);

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (imc < 24.9)
            {
                classificacao = "Peso normal";
            }
            else if (imc < 29.9)
            {
                classificacao = "Sobrepeso";
            }
            else if (imc < 34.9)
            {
                classificacao = "Obesidade grau 1";
            }
            else if (imc < 39.9)
            {
                classificacao = "Obesidade grau 2";
            }
            else
            {
                classificacao = "Obesidade grau 3";
            }

            Console.WriteLine($"Classificação: {classificacao}");
            */




            /*Exercicio 7
            Console.WriteLine("Digite um numero:");
            int.TryParse(Console.ReadLine(), out int num);

            if (num % 2 == 0)
                Console.WriteLine("É par");
            else
                Console.WriteLine("É impar");
            */




            /*Exercicio 8
            string classificacao;
            Console.WriteLine("Digite uma nota de 0 a 10:");
            int.TryParse(Console.ReadLine(), out int nota);

            if (nota <= 4)
            {
                classificacao = "Insuficiente";
            }
            else if (nota <= 5)
            {
                classificacao = "Regular";
            }
            else if (nota <= 9)
            {
                classificacao = "Bom";
            }
            else
            {
                classificacao = "Excelente";
            }
            
            Console.WriteLine($"Nota: {nota} - Classificação: {classificacao}");
            */





            /*Exercicio 9
            Console.WriteLine("Digite o salário bruto:");
            double.TryParse(Console.ReadLine(), out double salarioBruto);

            double inss = salarioBruto * 0.10;

            double salarioLiquido = salarioBruto - inss;

            Console.WriteLine($"Salário Bruto: {salarioBruto:C}");
            Console.WriteLine($"Desconto INSS : {inss:C}");
            Console.WriteLine($"Salário Líquido: {salarioLiquido:C}");
            */




            /*Exercicio 10
            Console.WriteLine("Escolha um numero para contagem regressiva:");
            int.TryParse(Console.ReadLine(), out int num);

            for (int i = num; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            */




            /*Exercicio 11
            Console.WriteLine("Escolha um numero para contagem regressiva:");
            int.TryParse(Console.ReadLine(), out int num);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
            */




            /*Exercicio 12

            Random rand = new Random();
            
            int escolha = 0;
            int numeroSorteado = 0;

            Console.WriteLine("Escolha um numero de 1 a 100");
            numeroSorteado = rand.Next(0, 100);
            do
            {
               int.TryParse(Console.ReadLine(), out escolha);

            if (escolha < numeroSorteado)
               Console.WriteLine("O numero sorteado é maior que o numero escolhido");

            else if (escolha > numeroSorteado)
               Console.WriteLine("O numero sorteado é menor que o numero escolhido");

            else
               Console.WriteLine("Acertou o numero");

            } while (escolha != numeroSorteado);
            */
        }
    }
}
