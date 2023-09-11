
/* //declare new array with 3 elements
string[] fraudulentOrderIDs = new string[3];

//assign values to elements in array
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789"; */

//another way to initialise arrays
string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

//output values of each order ID
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//reassign value of array
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//size of array
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

