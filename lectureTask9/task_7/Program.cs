// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//

Console.Clear();
int count = 1;
while(count <=100)
{
    if((count%3 == 0) & (count%5 == 0))
    {
         Console.Write("FizzBuzz");
    }
    else if(count%3 == 0)
    {
         Console.Write("Fizz");
    }
    else if(count%5 == 0)
    {
         Console.Write("Buzz");
    }
    else
    {
        Console.Write(count);
    }
    if (count == 100)
    {
        Console.Write(".");
    }
    else
    {
        Console.Write(", ");
    }
    count++;
}

