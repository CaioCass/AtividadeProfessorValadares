using System;

class 06_UnaProjects
{
    static void Main()
    {
        
        Console.WriteLine("--- FECHADURA ELETRÔNICA ---");
        Console.Write("Digite a senha (formato x-x-x): ");
        string entrada = Console.ReadLine();

    
        string[] componentes = entrada.Split('-');
        
        int estado = 0;

        foreach (string token in componentes)
        {

            switch (estado)
            {
                case 0:
                    if (token == "1") estado = 1;
                    else estado = 0;
                    break;

                case 1:
                    if (token == "2") estado = 2;
                    else estado = 0;
                    break;

                case 2:
                    if (token == "3") estado = 3;
                    else estado = 0;
                    break;
            }
        }

        // Verificação final
        if (estado == 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Senha Correta! Acesso concedido!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Senha Incorreta! Acesso negado.");
        }

        Console.ResetColor();
        Console.ReadKey();
    }
}