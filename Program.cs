// See https://aka.ms/new-console-template for more information
using SimpleProject;

Console.WriteLine("Choose operation: (+, -, *, /)");

string chosenOperation = Console.ReadLine();

Console.WriteLine("Type in the first number: ");
double x = Double.Parse(Console.ReadLine());

Console.WriteLine("Type in the second number: ");
double y = Double.Parse(Console.ReadLine());

double result = 0;
bool errorVar = false;

switch (chosenOperation)
{
    case "+":
        result = Calculator.Add(x, y);
        break;
    case "-":
        result = Calculator.Subtract(x, y);
        break;
    case "*":
        result = Calculator.Multiply(x, y);
        break;
    case "/":
        result = Calculator.Divide(x, y);
        break;
    default:
        Console.WriteLine("You have failed to type the correct operation symbol... Now it's over!");
        errorVar = true;
        break;
}
if (!errorVar) { Console.WriteLine("Result: " + result); }



