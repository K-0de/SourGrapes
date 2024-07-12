using System;

class Program
{
    static void Main()
    {
         int[] temperatures = new int[5];
         bool isWarmer = true;
         bool isColder = true;
         bool isValid = false;
       Console.WriteLine("Enter 5 daily temperatures (between -30 and 130 degrees Farenheit):");
        for (int i = 0; i < 5; i++){
        while (!isValid){
            if(int.TryParse(Console.ReadLine(), out temperatures[i])){
            if(temperatures[i] >= -30 && temperatures[i] <= 130){
                isValid = true;
                
                if(i > 0){
                    if(temperatures[i] > temperatures[i - 1]){
                        isColder = false;
                        } else if (temperatures[i] < temperatures[i - 1]){
                        isWarmer = false;
                        }
                        }
                    
                }
                
                
            else{
                    Console.WriteLine("Temperature " + temperatures[i] + " is invalid, Please enter a valid temperature between -30 and 130");
                }   
                
                }
            else {
            Console.Write("Please enter a valid integer");
            } 

        }  isValid = false;
        }
    if(isWarmer && !isColder){
        Console.WriteLine("Getting warmer");
    } else if(isColder && !isWarmer){
        Console.WriteLine("Getting cooler");
    } else {
        Console.WriteLine("It's a mixed bag");
    }
         Console.WriteLine("5-day temperature " + temperatures[0] + ","+ temperatures[1] +","+ temperatures[2] +","+ temperatures[3] +","+ temperatures[4]); 
       double sumOfTemps= temperatures[0] + temperatures[1] + temperatures[2] + temperatures[3] + temperatures[4];
        double averageTemp = sumOfTemps / 5;
        Console.WriteLine("Average temperature is: " + averageTemp);
        }
}    



