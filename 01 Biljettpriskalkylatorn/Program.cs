int numberOfTickets = 3; // Number of tickets purchased
decimal TicketPrice = 120.00m; // Base ticket price
decimal TotalPrice = 0.00m; // Total price after discount

Console.WriteLine("Number of tickets purchased: " + numberOfTickets);
Console.WriteLine("Base ticket price: $" + TicketPrice);

if (numberOfTickets >= 3) { 
    TotalPrice = numberOfTickets * TicketPrice * 0.9m; // Apply 10% discount
} else
{
    TotalPrice = numberOfTickets * TicketPrice; // No discount
}

Console.WriteLine("Total price: $" + TotalPrice);
