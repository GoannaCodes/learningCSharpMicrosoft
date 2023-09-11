// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, C#!");

/* //create new random object called dice
Random dice = new Random();
//call the stateful method dice.Next()
int roll = dice.Next(1, 7);
Console.WriteLine(roll); */

/* //overloaded methods - methods defined with multiple method signatures
//provides diff ways to call method/provide diff types of data
int number = 7;
string text = "seven";

Console.WriteLine(number); //int parameter
Console.WriteLine(); //no input
Console.WriteLine(text); //string */

//overloaded versions of Random.Next()
Random dice = new Random();
int roll1 = dice.Next(); //returns rand number between 0 to max value of int
int roll2 = dice.Next(101); //returns rand number up to given number
int roll3 = dice.Next(50, 101); //returns rand number between range given

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

