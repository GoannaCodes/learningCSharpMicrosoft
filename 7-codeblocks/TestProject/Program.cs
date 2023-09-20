bool flag = true;
int value = 0; //now accessible to both scopes
if (flag){
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"Outside of code block: {value}"); 