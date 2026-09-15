string correctUsername = "admin";
string correctPassword = "password";

Console.Write("Användarnamn: ");
string username = Console.ReadLine() ?? "";

Console.Write("Lösenord: ");
string password = Console.ReadLine() ?? "";


if (username == correctUsername && password == correctPassword)
{
    Console.WriteLine("Inloggning lyckades!");
} else if (username == "" || password == "")
{
    Console.WriteLine("Användarnamn och lösenord får inte vara tomma.");
}
else
{
    Console.WriteLine("Fel användarnamn eller lösenord.");
}