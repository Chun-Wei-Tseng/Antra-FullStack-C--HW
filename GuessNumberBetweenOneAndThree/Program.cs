// See https://aka.ms/new-console-template for more information

int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("Guess a number between 1 and 3:");
int userInput = int.Parse(Console.ReadLine());
if (userInput < 1 || userInput > 3)
{
    Console.WriteLine("Your guess is outside the range of valid numbers.");
}
else if (userInput < correctNumber)
{
    Console.WriteLine("Your guess is too low.");
}
else if (userInput > correctNumber)
{
    Console.WriteLine("Your guess is too high.");
}
else
{
    Console.WriteLine("Congratulations! You guessed the correct number.");
}