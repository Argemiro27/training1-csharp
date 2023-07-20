using System;

public class SistemaBanco
{
    public static void Main(string[] args)
    {
        string userName, password;
        float saldo, deposito, saque;
        int menu, op;

        Console.WriteLine("Qual é o seu nome?");
        userName = Console.ReadLine();
        Console.WriteLine("Oi, " + userName + ". Tudo bem?");
        Console.WriteLine("Vamos criar sua conta. Crie uma senha para sua conta.");
        password = Console.ReadLine();
        Console.WriteLine("Agora informe seu saldo.");
        saldo = float.Parse(Console.ReadLine());
        Console.WriteLine("Cadastro efetuado com sucesso! Digite qualquer tecla para ir para o menu principal.");
        Console.ReadKey();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Seu nome: " + userName);
            Console.WriteLine("Seu saldo: " + saldo);
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Sacar");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Sair");

            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Informe o valor do saque.");
                    saque = float.Parse(Console.ReadLine());
                    if (saldo >= saque)
                    {
                        saldo -= saque;
                        Console.WriteLine("Saque efetuado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para saque!");
                    }
                    Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Informe o valor do depósito.");
                    deposito = float.Parse(Console.ReadLine());
                    saldo += deposito;
                    Console.WriteLine("Depósito efetuado com sucesso.");
                    Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Obrigado por usar o nosso sistema! Até mais.");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Digite qualquer tecla para voltar ao menu principal.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
