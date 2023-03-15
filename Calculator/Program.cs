void Calculator()
{
    Console.WriteLine("Please input an operator: ");
    string sign = Console.ReadLine();
    Console.WriteLine("Please input the first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input the second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    int print;
    int Sum(int a, int b)
    {
        return a + b;
    }
    int Substract(int c, int d)
    {
        return c - d;
    }
    int Multiply(int a, int b)
    {
        return a * b;
    }
    int Divide(int a, int b)
    {
        return a / b;
    }
    switch (sign)
    {
        case "+":
            print = Sum(firstNumber, secondNumber);
            Console.WriteLine(print);
            break;
        case "-":
            print = Substract(firstNumber, secondNumber);
            Console.WriteLine(print);
            break;
        case "*":
            print = Multiply(firstNumber, secondNumber);
            Console.WriteLine(print);
            break;
        case "/":
            if (firstNumber == 0 || secondNumber == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                break;
            }
            print = Divide(firstNumber, secondNumber);
            Console.WriteLine(print);
            break;
        default:
            Console.WriteLine("Error!");
            break;
    }
}
Calculator();
    
    
    
    
    
    