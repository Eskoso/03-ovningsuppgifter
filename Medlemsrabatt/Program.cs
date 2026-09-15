int totalPurchaseAmount; // Example purchase amount
int totalDiscountEdge = 500;
decimal discountRate = 0.10m; // 10% discount
int seniorAge;
string[] memberTypes = ["Guldmedlem", "Silvermedlem", "Basmedlem"]; // member types
string member;

// Fråga användaren om hur mycket de köper för
Console.WriteLine("Hur mycket köper du för?:");
totalPurchaseAmount = Convert.ToInt32(Console.ReadLine());

// Se ifall användaren är senior (65 år eller äldre)
Console.WriteLine("Hur gammal är du?:");
seniorAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vilken medlemstyp är du? (1 Guldmedlem/2 Silvermedlem/3 Basmedlem)");

// välja medlemstyp baserat på användarens input
switch (Console.ReadLine())
{
    case "1":
        member = "Guldmedlem";
        break;
    case "2":
        member = "Silvermedlem";
        break;
    case "3":
        member = "Basmedlem";
        break;
    default:
        Console.WriteLine("Ogiltig medlemstyp. Ingen rabatt tillämpas.");
        member = "ingen";
        break;
}


// Guldmelem ELLER (över 65 år OCH handlat över 500kr)
if (member == "Guldmedlem" || (seniorAge >= 65 && totalPurchaseAmount >= totalDiscountEdge))
{
    decimal totalDiscount = totalPurchaseAmount * discountRate;
    Console.WriteLine($"Du får {totalDiscount} kr rabatt.");
    Console.WriteLine($"Totalt belopp: {totalPurchaseAmount - totalDiscount} kr");
}
else
{
    Console.WriteLine("Ingen rabatt.");
}