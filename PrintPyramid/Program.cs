// See https://aka.ms/new-console-template for more information

int totalRows = 5;
for (int currentRow = 1; currentRow <= totalRows; currentRow++)
{
    for (int space = 1; space <= totalRows - currentRow; space++)
    {
        Console.Write(" ");
    }
    for (int star = 1; star <= (2 * currentRow - 1); star++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}