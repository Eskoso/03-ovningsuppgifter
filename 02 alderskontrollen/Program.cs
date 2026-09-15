Console.WriteLine("What is your age?:");
int age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("You are a minor.");
}
else if (age >= 18 && age < 65)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a senior citizen.");
}