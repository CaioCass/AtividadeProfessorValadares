using System;
class 02_UnaProjects {
  static void Main() {
      
      Console.Write("Digite a altura do retangulo: ");
      
       if (int.TryParse(Console.ReadLine(), out int altura))
        {
          // LAÇO EXTERNO: Controla as linhas
          for (int i = 0; i < altura; i++){
              
             // LAÇO INTERNO: Imprime os asteriscos daquela linha
             for(int colunas = 0; colunas <= altura; colunas++){
                 Console.Write("* ");
             } 
             // Pula para a próxima linha após terminar os asteriscos
             Console.WriteLine();
              
          }
        }  
      
      Console.ReadKey();
  }
}