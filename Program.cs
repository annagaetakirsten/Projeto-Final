
string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 7 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[%] Exponciação");
Console.WriteLine("[!] Radiciação");
Console.WriteLine("[#] MediAritmetica");
Console.WriteLine("[>] Sair");
Console.WriteLine("[<] Sobre");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
       Calculadora.CalcularSoma();

        break;
    case "-":
        Calculadora.CalcularSubtracao();
    
        break;
    case "*":
       Calculadora.CalcularMultiplicacao();

        break;
    case "%":
      Calculadora.CalcularExponciação();
             break;

    case "/":
      Calculadora.CalcularDivisao();
      
      
        break;
    case "!":
      Calculadora.CalcularRadiciação();
      
            break;
    case ">":
      Calculadora.ExibeSair();
      
       
        break;
    case "#":
      Calculadora.CalcularMediAritmetica();
      
              break;
    case "<":
      Calculadora.ExibeMiniintroduçao();
      break;
      
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nObrigado por utilizar meu programa.");