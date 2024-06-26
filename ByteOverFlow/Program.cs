// See https://aka.ms/new-console-template for more information
// Originallu, the console can only print out value from 0 to 255 because byte can only hold values from 0 to 255
int max = 500;
for (byte i = 0; i < byte.MaxValue; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Warning: The loop has been terminated to prevent overflow.");