/* Challenge: update problematic code */

int[] numbers = {4, 8, 15, 16, 23, 42};
//declare variables outside so they can be used in local scope as well
int total = 0;
bool found = false; //since it hasn't been found yet
foreach (int number in numbers){
    
    total += number;

    if (number == 42){
        found = true;
    }
}

if (found)
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");