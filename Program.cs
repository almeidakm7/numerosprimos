using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Digite um número inteiro maior que 1: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if(numero <= 1)
        {
            Console.WriteLine("O número deve ser maior que 1.");
        }
        else
        {
            bool ehPrimo = true;

                for(int i = 2; i <= numero / 2; i++)
                {
                    if (numero % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }
            
                if (ehPrimo)
                {
                    Console.WriteLine("O número " + numero + " é primo.");
                }
                else
                {
                    Console.WriteLine("O número " + numero + " não é primo.");
                }
        }
    }
}