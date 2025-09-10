Random coin = new  Random();
int choices = coin.Next(0, 2);
string result = choices > 1 ? "heads" : "tails";
Console.WriteLine(result);


//* Another project to reinforce conditional branching concept.
string permission = "Admin | Manager";

int level = 55;

if (permission.Contains("Admin") && level > 55)
    Console.WriteLine("Welcome, Super Admin user.");
else if (permission.Contains("Admin") && level <= 55)
    Console.WriteLine("Welcome, Admin user.");
else if (permission.Contains("Manager") && (level == 20 || level > 20))
    Console.WriteLine("Contact an Admin for access");
else if (permission.Contains("Manager") && level < 20)
    Console.WriteLine("You don't have sufficient privileges");
else
    Console.WriteLine("You don't have sufficient privileges");