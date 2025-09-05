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