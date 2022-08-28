// See https://aka.ms/new-console-template for more information
Console.WriteLine("Good day, please provide your full name ");
var firstName = Console.ReadLine();



for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Choose a number from 1-4 of which calcualtor function you would you like to use \n" +
    "1. Addition \n" +
    "2. Subtraction \n" +
    "3. Multiplication \n" +
    "4. Division \n");
    int arithmeticChoice = Convert.ToInt32(Console.ReadLine());

    if(arithmeticChoice == 1)
    {
        Console.WriteLine("Enter two numbers to perform a simple math calculation");

        Console.WriteLine("Enter first number : ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number : ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int final = firstNumber + secondNumber;


        Console.WriteLine("Name : " + firstName + " \n\n" +
            "First Number : " + firstNumber + "\n" +
            "Second Number : " + secondNumber + "\n\n" +
            "Result : " + final);
    }
    else if (arithmeticChoice == 2 )
    {
        Console.WriteLine("Enter two numbers to perform a simple math calculation");

        Console.WriteLine("Enter first number : ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number : ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (secondNumber > firstNumber)
            {
                Console.WriteLine("Second number cannot be greater than first number.");
                Console.WriteLine("Enter second number : ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
            }
           

        }
        catch (Exception)
        {

        }

        int final = firstNumber - secondNumber;

        Console.WriteLine("Name : " + firstName + " \n\n" +
            "First Number : " + firstNumber + "\n" +
            "Second Number : " + secondNumber + "\n\n" +
            "Result : " + final);
    }
    else if (arithmeticChoice == 3)
    {
        Console.WriteLine("Enter two numbers to perform a simple math calculation");

        Console.WriteLine("Enter first number : ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number : ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int final = firstNumber *secondNumber;


        Console.WriteLine("Name : " + firstName + " \n\n" +
            "First Number : " + firstNumber + "\n" +
            "Second Number : " + secondNumber + "\n\n" +
            "Result : " + final);
    }
    else if (arithmeticChoice == 4)
    {
        Console.WriteLine("Enter two numbers to perform a simple math calculation");

        Console.WriteLine("Enter first number : ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number : ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        

        double final = (firstNumber  / secondNumber);


        Console.WriteLine("Name : " + firstName + " \n\n" +
            "First Number : " + firstNumber + "\n" +
            "Second Number : " + secondNumber + "\n\n" +
            "Result : " + Math.Round(final));
    }
}


