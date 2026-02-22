using System;
using System.Collections;

class 05_UnaProjects
{
    static void Main()
    {

        ArrayList conjuntoA = new ArrayList() { 1, 2, 3 };
        ArrayList conjuntoB = new ArrayList() { 2, 3, 4 };

        ArrayList uniao = CalcularUniao(conjuntoA, conjuntoB);
        
        ArrayList intersecao = CalcularIntersecao(conjuntoA, conjuntoB);

        ImprimirLista("Conjunto A", conjuntoA);
        ImprimirLista("Conjunto B", conjuntoB);
        ImprimirLista("União (A ∪ B)", uniao);
        ImprimirLista("Interseção (A ∩ B)", intersecao);

        Console.ReadKey();
    }

    static ArrayList CalcularUniao(ArrayList a, ArrayList b)
    {
        ArrayList resultado = new ArrayList();

        resultado.AddRange(a);

        foreach (var item in b)
        {
            if (!resultado.Contains(item))
            {
                resultado.Add(item);
            }
        }
        return resultado;
    }

    static ArrayList CalcularIntersecao(ArrayList a, ArrayList b)
    {
        ArrayList resultado = new ArrayList();

        foreach (var item in a)
        {
            if (b.Contains(item))
            {
                resultado.Add(item);
            }
        }
        return resultado;
    }

    static void ImprimirLista(string titulo, ArrayList lista)
    {
        Console.Write($"{titulo}: [ ");
        for (int i = 0; i < lista.Count; i++)
        {
            Console.Write(lista[i] + (i < lista.Count - 1 ? ", " : ""));
        }
        Console.WriteLine(" ]");
    }
}