using System;
using System.Security.AccessControl;
namespace funcaotabuada;

class ComFuncao

{
    static void exibirtabuada(int numero)
    {
        Console.WriteLine("Qual tabuada deseja imprimir?");
        numero = int.Parse(Console.ReadLine());
        int contador = 1;

        while (contador <= 10 )
        {
            Console.WriteLine($"{numero} X {contador} = {numero * contador}");
            contador++;
        }
    }
    static void Main(string[] args)
    {
        
        Console.WriteLine("Qual tabuada deseja imprimir?");
        int numero = int.Parse(Console.ReadLine());
        exibirtabuada (numero);
        
    }


}

