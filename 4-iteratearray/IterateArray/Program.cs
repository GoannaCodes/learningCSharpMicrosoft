/* //example of how to iterate through arrays with foreach loop
string[] names = {"Rowena", "Robin", "Bao"};
foreach (string name in names){ //loops through all objects in names array
    Console.WriteLine(name);
}
 */
 
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach(int items in inventory){
    sum+= items; //add up total items per iteration
    bin++; //keeps track of current iteration of loop
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
