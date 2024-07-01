using System;

class Program
{
    static void Main()
    {
        
     
      static bool IsPerfect(int number)
      {
          int sumOfDivisors = 0;

          for (int i = 1; i <= number / 2; i++)
          {
              if (number % i == 0)
              {
                  sumOfDivisors += i;
              }
          }

          return sumOfDivisors == number;
      }
      
      
      
      
      Console.WriteLine("Enter a number between 1 and 10,000 to determine :");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (IsPerfect(number))
            {
                Console.WriteLine("Perfect");
            }
            else
            {
                Console.WriteLine("Not Perfect");
            }
        }
       
    }

   
}