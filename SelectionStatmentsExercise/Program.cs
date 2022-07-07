Console.WriteLine("What is my favorite number?");

var r = new Random();
var favNumber = r.Next(1, 1000);
int userInput;



do
{
    Console.WriteLine("Pick a number from 1 to 1000");
    userInput = int.Parse(Console.ReadLine());

    if (userInput < favNumber)
    {
        Console.WriteLine("too low");
    }
    else if (userInput > favNumber)
    {
        Console.WriteLine("too high");
    }
    else
    {
        Console.WriteLine("Congrats! You guessed it!");
    }
    
}
while (userInput != favNumber);