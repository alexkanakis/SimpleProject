using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject
{
    public class Calculator
    {
        static string[] operations = new string[4] { "+", "-", "*", "/" };

        public void RunCalculator()
        {

            //Declaring Variables
            double x;
            double y;
            double result;
            string chosenOperation;
            string anotherCalc;

            //Getting chosen operation
            Console.WriteLine("Choose operation: (+, -, *, / or 'exit' to close)");
            chosenOperation = GetOperator();

            //Getting Numbers
            Console.WriteLine("Type in the first number: ");
            x = GetNumber();
            Console.WriteLine("Type in the second number: ");
            y = GetNumber();

            //Performing the chosen operation
            result = Calculate(x,y,chosenOperation);
            Console.WriteLine("The result is " + result + "\n(Y)es or (N)o to perform another calculation:");

            //Checking if the user wants to perform another calculation
            anotherCalc = Console.ReadLine();
            if(anotherCalc == "Y")
            {
                RunCalculator();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private string GetOperator()
        {
            //Get the operator
            string myOperator = Console.ReadLine();

            //make sure it's a valid operator
            while (!operations.Contains(myOperator))
            {
                Console.WriteLine("Choose a valid operator");
                myOperator = Console.ReadLine();
            }

            return myOperator;
 
        }

        private double GetNumber()
        {
            double num;

            //Trying to parse the number, saving the result of the check on a variable
            bool parseCheck = Double.TryParse(Console.ReadLine(), out num);

            //make sure an actual number is parsed
            while (!parseCheck)
            {
                Console.WriteLine("You didn't type an actual number! Try again:");
                parseCheck = Double.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }

        private double Calculate(double x,double y,string operation)
        {
            double result;
            switch (operation)
            {
                case "+":
                    result = Add(x, y);
                    break;
                case "-":
                    result = Subtract(x, y);
                    break;
                case "*":
                    result = Multiply(x, y);
                    break;
                case "/":
                    result = Divide(x, y);
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }

        private double Add(double x, double y)
        {
            return (x + y);
        }

        private double Subtract(double x, double y)
        {
            return (x - y);
        }

        private double Multiply(double x, double y)
        {
            return (x * y);
        }

        private double Divide(double x, double y)
        {
            return (x / y);
        }

        
    }

}
