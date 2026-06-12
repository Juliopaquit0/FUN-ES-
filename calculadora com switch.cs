using System;
using System.Runtime.InteropServices;

class TabuadaExibi
{
    static void ExibirTabu(int numero, int limite, string operacao)
    {
        int contador = 1;
        while (contador <= limite)
        
        {

            switch (operacao)
            {
                case "+":

                 Console.WriteLine($"{numero} + {contador} = {numero + contador}");
                 break;

                 case "-":
                  Console.WriteLine($"{numero} - {contador} = {numero - contador}");
                  break;

                  case "*":
                   Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                   break;

                   case "/":

                    Console.WriteLine($"{numero} / {contador} = {numero / contador}");
                    break;

                    default:
                    Console.WriteLine("operação invalida!!");
                    break;
            }
            contador++;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma operação valida para a operação: ");
        string operacao = Console.ReadLine();

        Console.Write("Digite um número para exibir a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Digite o limite da tabuada: ");
        int limite = int.Parse(Console.ReadLine());

        ExibirTabu(numero, limite , operacao);
    }
}
