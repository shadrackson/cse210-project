using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);
        
        string letter = "";
        string sign= "";
        
        if (score >= 90)
        {
            letter = "A";
        }

        else if (score >=80)
        {
            letter = "B";
        }

         else if (score >=70)
        {
            letter = "C";
        }

         else if (score >=60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        int lastDigit = score % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }
     

        Console.WriteLine($"Your grade is {letter}{sign}");


        if (score >= 70)
        
        {
            Console.WriteLine("Congratulations! You passed the course and ready to proceed to the next block.");
        }

        else
        {
            Console.WriteLine("Thank you for your hardwork! However you did not meet the criteria, you can retake the course.");
        }

        
    }
}
