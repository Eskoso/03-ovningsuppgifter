double numerator;
double denominator;
double result;

Console.WriteLine("mata in täljare:");
numerator = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("mata in nämnare:");
denominator = Convert.ToDouble(Console.ReadLine());

result = denominator != 0 ? numerator / denominator : 0;
Console.WriteLine(denominator != 0 ? $"Resultat: {result}" : $"Resultat: {result} - Fel: nämnaren får inte vara 0.");