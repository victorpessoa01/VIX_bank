using System;
using System.Data;

public class While_Investi
{
    public static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("             - - - VIX BANK Invest - - -            ");
        Console.WriteLine("");

        Console.WriteLine("Sejam Bem Vindos(as) ao nosso Sistema de banco online de Investimento");
        Console.WriteLine("");

        string nome, senha = "victor123";
        string user = "Victor Pessoa";

        Console.WriteLine("Insira seus Dados de Login");
        Console.WriteLine("Usuario:");
        nome = Console.ReadLine();
        Console.WriteLine("Senha:");
        senha = Console.ReadLine();

        if (nome=="Victor01" && senha=="victor123")
        {
            Console.WriteLine("");
            Console.WriteLine("ACESSO PERMITIDO");
            Console.WriteLine("");
            Console.WriteLine("Bem Vindo "+user);

            double money, taxainv, invest, juros;
            int mes, cont = 1;

            Console.WriteLine("Quanto deseja Investir?");
            money = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Qual a Taxa Mensal que deseja aplicar?");
            juros = double.Parse(Console.ReadLine());
            taxainv = juros / 100;

            Console.WriteLine("Em quantos meses deseja receber o Valor?");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            while (cont <= mes)
            {
                invest = money + (money * taxainv);
                Console.WriteLine("O Saldo do " + cont + "ª Mês é de " + money);
                cont = cont + 1;
            }
            Console.WriteLine("");
            Console.WriteLine("Seu Saldo Total é de "+money);
        }

    }
}
