int idade = 10;
string nomeCliente = "Millena";
decimal preco = 20M;
char letra = 'a';
var nomeCompleto = "Millena Kappaun";
var altura = 180;
Console.WriteLine("Digite seu nome:");//imprimi uma mensagem
nomeCompleto = Console.ReadLine();
Console.WriteLine("Bem vindo " + nomeCompleto + "!");
Console.WriteLine();
Console.Write("Digite a sua idade...");
var linha = Console.ReadLine();
idade = int.Parse(linha);// int.Parse converter um numero inteiro (rastrear)
Console.WriteLine("Idade Informada " + idade);
if (idade < 18)
    Console.WriteLine("Você não pode entrar");
Console.ReadKey();//vai esperar uma ação para encerrar o programa
//Console.ReadLine();//consigo capturar os dados
