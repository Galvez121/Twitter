using System;

class Twitter
{
    public static void Main(string[] args)
    {
        // Module 3 Exercise 3.1

        Console.WriteLine("Type your message");

        string message = Console.ReadLine();

        if(message.Length <= 140){
            Console.WriteLine("Posted");
        }
        else{
            Console.WriteLine("Rejected");
        }
      

    }
}