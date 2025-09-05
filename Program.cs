Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration}");
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day");
    Console.WriteLine($"Renew to save {discountPercentage}%");
}
else if (daysUntilExpiration > 10)
{
    Console.WriteLine("");
}
else
{
    Console.WriteLine("Your subscription has expired!");
}

if (daysUntilExpiration <= 5)
{
    Console.WriteLine("Discount 10%, be offered");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Discount of 20%, to be offered");
}