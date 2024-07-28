using System;

class Program
{
    static void Main()
    { 
        int menuChoice = 0;
         while(menuChoice != 2){
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************"); 
       Console.WriteLine();
        Console.WriteLine("Please Enter the following number below from the following menu:");
           Console.WriteLine(); 
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
        menuChoice = Convert.ToInt32(Console.ReadLine()); 


        if(menuChoice == 1){ 
            Console.WriteLine("Please enter the number of contestants in the previous year:");
            int contestantsPrevious = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of contestants this year:");
            int contestantsCurrent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Last year's competition had " + contestantsPrevious + " contestants, and this year's has " + contestantsCurrent + " contestants.");
            Console.WriteLine("Revenue expected this year is $" +(contestantsCurrent* 25));
            if(contestantsCurrent>(contestantsPrevious*2)){
                Console.WriteLine("The competition is more than twice as big this year!");
            } 
            else if((contestantsCurrent>contestantsPrevious) && (contestantsCurrent<=(contestantsPrevious*2))){
                Console.WriteLine("The competition is bigger than ever!"); 
                }
            else {
                Console.WriteLine(" A tighter race this year! Come out and cast your vote!");
            }

            }
            Console.WriteLine();
            Console.WriteLine();
            }


                         
        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
        Console.ReadKey(); //holds the screen

            }
    }



        