using System;
using System.Collections.Generic;

class 03_UnaProjects
{
    static void Main()
    {
        Console.Write("Digite a expressão: ");
        string expressao = Console.ReadLine();

        if (EstaEquilibrado(expressao))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nA equação está equilibrada e correta!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nA equação está desequilibrada ou fora de ordem.");
        }

        Console.ResetColor();
        Console.ReadKey();
    }

    static bool EstaEquilibrado(string texto)
    {
        Stack<char> pilha = new Stack<char>();

        foreach (char caractere in texto)
        {
            // Se for abertura, empilha
            if (caractere == '(' || caractere == '[' || caractere == '{')
            {
                pilha.Push(caractere);
            }
            // Se for fechamento, verifica consistência
            else if (caractere == ')' || caractere == ']' || caractere == '}')
            {
                // Se encontrar um fechamento com a pilha vazia, está errado
                if (pilha.Count == 0) return false;

                char topo = pilha.Pop();

                // Verifica se o par combina (Regra A e B)
                if (caractere == ')' && topo != '(') return false;
                if (caractere == ']' && topo != '[') return false;
                if (caractere == '}' && topo != '{') return false;
            }
        }

        // Se ao final a pilha estiver vazia, tudo foi fechado corretamente
        return pilha.Count == 0;
    }
}