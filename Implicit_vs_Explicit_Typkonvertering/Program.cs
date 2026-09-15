int tal = 500;

double nyttIntTal = tal; // Implicit conversion from int to double

double stortTal = 123.45;

int nyttdoubleTal = (int)stortTal; // Explicit conversion from double to int

Console.WriteLine($"Implicit conversion: {nyttIntTal}");
Console.WriteLine($"Explicit conversion: {nyttdoubleTal}");