using RegistroFuncionarioApp;
using System.Globalization;
using System.Collections.Generic;

List<Funcionario> Lista = new List<Funcionario>();

Console.WriteLine("Quantos empregados serão cadastrados?");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine(n + "° Empregado:");
    Console.Write("ID: ");
    int ID = int.Parse(Console.ReadLine());

    Console.Write("Nome: ");
    string Nome = Console.ReadLine();

    Console.Write("Salário: ");
    double Salario = double.Parse(Console.ReadLine());

    Lista.Add(new Funcionario(ID, Nome, Salario));
}

Console.Write("Qual funcionário você deseja aumentar o salário? ");
int IDF = int.Parse(Console.ReadLine());

Funcionario func = Lista.Find(x => x.ID == IDF);

if (func != null)
{
    Console.Write("Qual é a porcentagem? ");
    double porcentagem = double.Parse(Console.ReadLine());

    func.Aumento(porcentagem);
}
else
{
    Console.WriteLine("ID não registrado");
}

foreach (Funcionario funcionario in Lista)
{
    Console.WriteLine(funcionario);
}


