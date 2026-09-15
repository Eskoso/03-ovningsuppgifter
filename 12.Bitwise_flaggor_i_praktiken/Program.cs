int read = 1;
int write = 2;
int execute = 4;

int permissions = read | write; // Combine read and write permissions using bitwise OR

Console.WriteLine($"Rättigheter: {permissions}");

// konmtrollera om read finns
if ((permissions & read) != 0)
{
    Console.WriteLine("Read finns.");
}
else
{
    Console.WriteLine("Read finns inte.");
}

// konmtrollera om execute finns
if ((permissions & execute) != 0)
{
    Console.WriteLine("Execute finns.");
}
else
{
    Console.WriteLine("Execute finns inte.");
}

permissions = permissions ^ write;

Console.WriteLine($"Rättigheter efter XOR: {permissions}");