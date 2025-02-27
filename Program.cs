using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static double raio;
        static void Main(string[] args)
        {
            #region Exercicio Triangulo
            ////instancia da classe triangulo criada
            //Triangulo x = new Triangulo();
            //Triangulo y = new Triangulo();

            ////declaracao das variaveis
            //double areay, areax;

            //Console.WriteLine("Insira as medidas do Triangulo X: ");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Insira as medidas do Triangulo Y: ");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ////p = (x.A + x.B + x.C) / 2.0;

            ////x.Area = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            ////p = (y.A + y.B + y.C) / 2.0;

            ////y.Area = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            //areax = x.Area();
            //areay = y.Area();


            //Console.WriteLine("A area do triangulo X é: " + areax.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("A area do triangulo Y é: " + areay.ToString("F4", CultureInfo.InvariantCulture));

            //if (areax > areay) {
            //    Console.WriteLine("Maior area: X");
            //} else {
            //    Console.WriteLine("Maior area: Y");
            //}


            #endregion

            #region Exercicio Pessoa
            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa");
            //p1.Nome = Console.ReadLine();
            //p1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa");
            //p2.Nome = Console.ReadLine();
            //p2.Idade = int.Parse(Console.ReadLine());
            //if (p1.Idade > p2.Idade) {
            //    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            //} else {
            //    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            //}
            #endregion

            #region Exercicio funcionario
            //Funcionario f1 = new Funcionario();
            //Funcionario f2 = new Funcionario();

            //double media;

            //Console.WriteLine("Dados do primeiro funcionario");
            //Console.Write("Nome: ");
            //f1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //f1.Idade = int.Parse(Console.ReadLine());
            //Console.Write("Salário: ");
            //f1.Salario = double.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do primeiro funcionario");
            //Console.Write("Nome: ");
            //f2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //f2.Idade = int.Parse(Console.ReadLine());
            //Console.Write("Salário: ");
            //f2.Salario = double.Parse(Console.ReadLine());

            //media = (f1.Salario + f2.Salario) / 2.0;

            //Console.WriteLine("Salario medio = " + media.ToString("F2", CultureInfo.InvariantCulture));

            #endregion

            #region Exercicio Produtos

            //Produto p = new Produto();

            //Console.WriteLine("Entre com os dados do produto: ");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();

            //Console.Write("Preco: ");
            //p.Preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantidade: ");
            //p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            #region meu jeito
            //Console.WriteLine("Dados do produtudo: " + p.Nome + ", $" + p.Preco + ", " + p.Quantidade + " unidades, Total: $ " + p.ValorTotalEmEstoque());

            //Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            //p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Dados atualizados: " + p.Nome + ", $" + p.Preco + ", " + p.Quantidade + " unidades, Total: $ " + p.ValorTotalEmEstoque());

            //Console.WriteLine("Digite o número de produtos a ser removido ao estoque: ");
            //p.RemoverProdutos(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Dados atualizados: " + p.Nome + ", $" + p.Preco + ", " + p.Quantidade + " unidades, Total: $ " + p.ValorTotalEmEstoque());
            #endregion

            #region jeito correto com toString
            //Console.WriteLine("Dados do produto: " + p);

            //Console.Write("Digite a quantidade de produtos a serem adcionadas: ");
            //p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Dados atualizados: " + p);

            //Console.Write("Digite a quantidade de produtos a serem removidos: ");
            //p.RemoverProdutos(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Dados atualizados: " + p);
            #endregion
            #endregion


            #region Exercicios fixacao
            #region exercicio 1
            //Retangulo r = new Retangulo();
            //Console.WriteLine("Entre a largura e altura do retângulo: ");
            //r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine(r);
            #endregion

            #region exercicio 2
            //Funcionario f = new Funcionario();

            //Console.Write("Nome: ");
            //f.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Imposto: ");
            //f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Funcionário: " + f);

            //Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            //f.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            //Console.WriteLine("Dados atualizados: " + f);
            #endregion

            #region exercicio 3
            //double media; 

            //Aluno a = new Aluno();


            //Console.Write("Nome do aluno: ");
            //a.Nome = Console.ReadLine();

            //Console.WriteLine("Digite as três notas do aluno: ");
            //a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //media = a.CalculaMediaAluno();



            //Console.WriteLine(a.VerificaSituacao(media));
            #endregion


            #endregion

            #region Exercicio membros static

            //Console.Write("Entre o valor do Raio: ");
            //Calculadora.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //raio = Calculadora.Raio;

            //Console.WriteLine("\nCircunferência: " 
            //    + Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture) 
            //    + "\nVolume: "+Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture) 
            //    + "\nValor de PI: "+ Calculadora.Pi);
            #endregion

            #region Exercicio fixacao static
            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.Dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Converter().ToString("F2", CultureInfo.InvariantCulture));
            #endregion

        }
    }
}
