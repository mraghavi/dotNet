// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello this is Calculator");

Console.WriteLine("Enter First number:");
var userInput1 = Console.ReadLine();
var num1 = int.Parse(userInput1);

Console.WriteLine("Enter Second number:");
var userInput2 = Console.ReadLine();
var num2 = int.Parse(userInput2);

Console.WriteLine("Enter [A]dd");
Console.WriteLine("Enter [S]ubstract");
Console.WriteLine("Enter [M]ultiply");
Console.WriteLine("Enter [D]ivide");

string choice = Console.ReadLine();


if (choice == "A" || choice == "a")
{
    var sum = num1 + num2;
    Console.WriteLine(sum);
}
else if (choice == "S" || choice == "s")
{
    var sub = num1 - num2;
    Console.WriteLine(sub);
}
else if (choice == "M" || choice == "m")
{
    var multiply = num1 * num2;
    Console.WriteLine(multiply);
}
else if (choice == "d" || choice == "D")
{
    var div = num1 / num2;
    Console.WriteLine(div);
}
else 
{
    Console.WriteLine("press the correct key");
}

Console.WriteLine("Press any key to exit");
Console.ReadKey();