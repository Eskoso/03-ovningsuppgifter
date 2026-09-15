int persons = 4;
int totalCandy = 23;

int candyPerPerson = totalCandy / persons;
int remainingCandy = totalCandy % persons;

Console.WriteLine($"Varje person får {candyPerPerson} godisbitar.");
Console.WriteLine($"Det blir {remainingCandy} godisbitar över.");