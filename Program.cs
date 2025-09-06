//* introduction to arrays

//string[] fraudulentOrderIDs = new string[3];
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
/*fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "b456";
fraudulentOrderIDs[2] = "C789";
*/
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "FOOO";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//* for each to loop in array elements

int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;

foreach (int item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} (Running total: {sum})");

}
Console.WriteLine($"We have {sum} items in inventory.");

//*Detecting frauds.

string[] frauds = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string item in frauds)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}
;

//* Comments in C#.

string firstName = "Bob";
int widgetsSold = 7;

Console.WriteLine($"{firstName} sold {widgetsSold}");
//* testing change to the message.
//* int widgetsSold = 7
//* Console.WriteLine($"{firstName} sold {widgetsSold}");


/* **
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
  **
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}
;

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
;