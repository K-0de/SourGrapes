using System; 

class Program {
  public static void Main (string[] args) {
     Console.WriteLine("Enter text here");
    int charCount = Console.ReadLine().Length;
    if((charCount > 140)){
      Console.WriteLine("Rejected");
      }
    else Console.WriteLine("Posted");
    
  }
  
    }
   