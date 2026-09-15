int number1 = int.MaxValue;
int number2 = 2;

int result = unchecked(number1 * number2);
Console.WriteLine($"Unchecked: {result}");

try
{
    result = checked(number1 * number2);
    Console.WriteLine($"Checked: {result}");
}
catch (OverflowException e)
{
    Console.WriteLine($"Checked: Talet blev för stort!");
}