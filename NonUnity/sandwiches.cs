using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3schoolsTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //COMMENT: definitions var1 is sandwhich cost and var2 is money put in to pay
            int var1;
            double var2;

            Console.WriteLine("Hello! I will be your personal robot assistant today. How many sandwiches would you like?");
            var1 =  Convert.ToInt32(Console.ReadLine());
            

            double SWcost = Convert.ToDouble(var1) * 9.50;

            Console.WriteLine("Sandwiches are 9.50, Your total is: " + SWcost + " dollars. Please input cash:");
            var2 = Convert.ToInt32(Console.ReadLine());

            
            double change;
            //COMMENT: Warning refer to comment ChangeIssue
            bool stupid;

            if (var2 < SWcost) {


                
                Console.WriteLine("The ammount of sandwiches requested costs more than the cash you put in. Please insert more cash or type REFUND to take cash out");
                string dec = Console.ReadLine();
                if (dec == "REFUND") {
                    Console.WriteLine("Returning " + var2 + " dollars");
                }
                else if (Convert.ToInt32(dec) + var2 < SWcost)
                {
                    Console.WriteLine("error: Ejecting cash. you have failed to bring your cash to " + SWcost + " returning." + (var2 + Convert.ToInt32(dec) + "dollars"));
                }
                else
                { double newVar2 = Convert.ToInt32(dec) + var2;
                    Console.WriteLine("Your new balance is: " + newVar2 + " dollars.");
                    
                }
               
               
            }

            //COMMENT: ChangeIssue Change is a big problem in the code. It needs to be fixed by rewriting var2 in the if statement above or 
            //assigning a bool that changes depending on if you payed the right ammount at the beginning or not 
            //(ex: bool stupid, then if stupid = true, change = NewVar2- SWcost, if stupid = false, change = var2 - swcost)
            
            change = var2 - SWcost;

            Console.WriteLine("We will be preparing your " + var1 + " sandwiches. In the meantime please take your receipt number and your change.");
            //I wanna import time, ex time,wait(2) then write message below
            //I wanna import rng, ex reciept num = rng from 100-200 or smthn. 
            Console.WriteLine("Here is your change. " + change + " dollars in total.");
            //create a random wait time(3 - 7 sec) based on reciept num
            Console.WriteLine("Your receipt number is being called. please approach the front desk robot to aquire your " + var1 + " sandwiches");
            //time.wait
            Console.WriteLine("Now that you have recieved your sandwiches, please leave the establishment and proceed to the outdoor seating area");








        }
    }
}
