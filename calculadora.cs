public class Calculadora
{
    public static void CalcularSoma()
    {
        double a, b, resultado;

        Console.WriteLine("--- Soma A+B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Soma(a, b);

        Console.WriteLine($"{a} somado com {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularSubtracao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Subtração A-B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Subtracao(a, b);

        Console.WriteLine($"{a} subtraindo {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularMultiplicacao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Multiplicacao(a, b);

        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularDivisao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Divisão A/B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        if (b == 0)
        {
            Console.WriteLine("\nNão é possível dividir por zero.");
        }
        else
        {
            resultado = Aritmetica.Divisao(a, b);

            Console.WriteLine($"{a} dividido por {b} é {resultado}");
        }

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }


        public static void CalculanerExponciação()
        {
            Double Potencia, NumeroElevado, NumeroExpoente;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n----Exponenciação----\n");
            Console.ResetColor();

            Console.Write("Digite o número que será elevado: ");
            NumeroElevado = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            NumeroExpoente = Convert.ToDouble(Console.ReadLine());

            Potencia = Math.Pow(NumeroElevado, NumeroExpoente);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\n{NumeroElevado} elevado a {NumeroExpoente} é igual a: {Potencia:N2}\n");
            Console.ResetColor();

            Console.WriteLine("Digite qualquer tecla para continuar: ");
            Console.ReadKey(); 
        }

        static void CalcularRadiciação()
        {
            Double Opcao;
            Double Raiz;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n----Radiciação----");
            Console.ResetColor();

            Console.Write("\nDigite um numero inteiro e positivo: ");
            Opcao = Convert.ToDouble(Console.ReadLine());

            if (Opcao >= 0)
            {
                Raiz = Math.Sqrt(Opcao);

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"\n A raíz de {Opcao} é: {Raiz:N2}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNúmero invalido!");
                Console.ResetColor();
            }
            Console.WriteLine("\nDigite qualquer tecla para continuar: ");
            Console.ReadKey();
       
         }

   public static void CalcularMediAritmetica()
        {double n1, n2, n3, Media;

Console.WriteLine("Digite um numero, Por Favor:");
n1 = Convert.ToDouble(Console.ReadLine())!;

Console.WriteLine("Digite o segundo numero, Por favor:");
n2 = Convert.ToDouble(Console.ReadLine())!;

Console.WriteLine("Digite o terceiro numero, Por favor:");
n3 = Convert.ToDouble(Console.ReadLine());

Media = (n1+n2+n3) / 3;

Console.WriteLine($"A media é:{Media:N1}");


        }

public static string ExibeSair()
    {
        Console.Clear();
        string saida;

        Console.WriteLine("Deseja sair do programa?");
        Console.WriteLine("S-Sim || N-Não");
        Console.Write("Escolha uma opção: ");
        saida = Console.ReadLine()!;

        switch (saida.ToUpper())
        {
            case "S":

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nObrigado por usar este programa!");
                Console.ResetColor();

                return saida;

            case "N" or "n":
                return saida;

                default:
                return "N";
        }
    }

     public static void ExibeMiniintroduçao()
    {
        Console.Clear();
        Console.WriteLine("-- Um pouco sobre mim e a motivação deste projeto--\n");

        Console.WriteLine("Me chamo Anna Beatrice, tenho 18 anos e curso Informática na Etec Adolpho Berezin, estou no 1° Módulo do Ensino Técnico no ano de 2022.");

        Console.WriteLine("Este projeto foi realizado com a intenção de por em prática o que aprendi neste semestre do curso\n");
        Console.WriteLine("Quero parabenizar e agradecer os professores, Ermogenes Palacio e Diego Neri, por serem ótimos professores e passar conhecimento para tantos alunos, a ponto de motivá-las a seguirem nessa área");

        Console.WriteLine("Pressione uma tecla para continuar: ");
        Console.ReadKey();
    }

}

        