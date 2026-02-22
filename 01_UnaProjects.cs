using System;
class 01_UnaProjects {
  static void Main() {
      
      Console.Write("Digite a altura do triangulo: ");
      
       if (int.TryParse(Console.ReadLine(), out int altura))
        {
          // LAÇO EXTERNO: Controla as linhas
          for (int i = 0; i <= altura; i++){
              
             // LAÇO INTERNO: Imprime os asteriscos daquela linha
             for(int colunas = 0; colunas <= i; colunas++){
                 Console.Write("* ");
             } 
             // Pula para a próxima linha após terminar os asteriscos
             Console.WriteLine();
              
          }
        }  
      
      Console.ReadKey();
  }
}