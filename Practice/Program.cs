// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string name = "madam";
string name2 = new string(name.Reverse().ToArray());


Console.WriteLine(name.GetType());

Console.WriteLine(name2);

for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine("====>>>>", name[i]);
}



if (name == name2)
{
    Console.WriteLine("its palindorom");
}
else
{
    Console.WriteLine("its not palindorom");
}

for (int i = 1; i <= 10; i++)
{
    if (i % 2 != 0)
        Console.WriteLine("Odd Numbers " + i);
}

for (int i = 0; i < 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Even Number " + i);
    }
}



for (int num = 2; num <= 20; num++)
{
    if (IsPrime(num))
    {
        Console.WriteLine($"\nTable of {num}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}

static bool IsPrime(int number)
{
    if (number < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}


// Stuck the screen
Console.ReadKey();
