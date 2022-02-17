using System;

namespace DiamanteLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho_diamante = 0, tamanho = 0;

            char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            char[] espaco = { ' ' };

            Console.WriteLine("Insira o tamanho do diamante de letras:");
            tamanho = int.Parse(Console.ReadLine());

            tamanho_diamante = (tamanho / 2) + 1;
            int quantidade_espacos = (tamanho_diamante - 1);

            for (int i = 0; i < tamanho_diamante; i++)
            {
                for (int j = 0; j < quantidade_espacos; j++)
                {
                    Console.Write(espaco);
                }

                Console.WriteLine(alfabeto[i]);

                quantidade_espacos--;
            }

            for (int i = 0; i < tamanho_diamante; i++)
            {
                for (int j = 0; j < quantidade_espacos; j++)
                {
                    Console.Write(espaco);
                }

                Console.WriteLine(alfabeto[i]);

                quantidade_espacos++;
            }
        }
    }
}
