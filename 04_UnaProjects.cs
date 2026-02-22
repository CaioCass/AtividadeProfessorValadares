using System;

class 04_UnaProjects
{
    static void Main()
    {
        string input = "soma = 10 + 20 ;";
        
        Console.WriteLine($"Analisando a expressão: {input}\n");

        string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokens)
        {
            string categoria = CategorizarToken(token);
            Console.WriteLine($"• {token} -> {categoria}");
        }

        Console.ReadKey();
    }

    static string CategorizarToken(string token)
    {
        if (int.TryParse(token, out _))
        {
            return "Número";
        }

        switch (token)
        {
            case "=": return "Atribuição";
            case "+": 
            case "-": 
            case "*": 
            case "/": return "Operador";
            case ";": return "Fim de instrução";
        }

        if (char.IsLetter(token[0]))
        {
            return "Identificador";
        }

        return "Desconhecido";
    }
}