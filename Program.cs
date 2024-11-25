// Write a program that calculates the delta and the roots of a quadratic equation.
void excercise1()
{
    double a = DoubleInput();
    double b = DoubleInput();
    double c = DoubleInput();

    double delta, x1, x2;

    if (a == 0) Console.WriteLine("Not a quadratic equasion");
    else
    {
        delta = (Math.Pow(b, 2) - (4 * a * c));
        if (delta < 0) Console.WriteLine("No solution");
        else if (delta > 0)
        {
            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }
        else
        {
            x1 = -b / (2 * a);
            Console.WriteLine($"One solution: {x1}");
        }
    }
}

double DoubleInput()
{
    Console.Write("Enter a number: ");
    double val = Convert.ToDouble(Console.ReadLine());
    return val;
}

// excercise1();

// ------------------------------

/* Write a calculator that computes: sum, difference, product, quotient, power, root, 
 * and values of trigonometric functions for a given angle. Use the Math library, e.g., Math.Sin(2.5). 
 * Please remember that the angle values passed to the functions are measured in radians. 
 * Display the results of the algorithms in the console. Use a switch-case construct 
 * and a while loop to handle the menu. */

void excercise2()
{
    bool exit = false;
    while (!exit)
    {
        Console.WriteLine("=====CALCULATOR=====");
        Console.WriteLine("Enter the number symbolising the operation you want to perform.");
        Console.WriteLine("1. Sum");
        Console.WriteLine("2. Difference");
        Console.WriteLine("3. Product");
        Console.WriteLine("4. Quotient");
        Console.WriteLine("5. Power");
        Console.WriteLine("6. Root");
        Console.WriteLine("7. Trigonometry");
        Console.WriteLine("8. End the program");

        double choice = DoubleInput();
        switch (choice)
        {
            case 1:
                sum();
                break;
            case 2:
                difference();
                break;
            case 3:
                product();
                break;
            case 4:
                quotient();
                break;
            case 5:
                power();
                break;
            case 6:
                root();
                break;
            case 7:
                trigonometry();
                break;
            case 8:
                exit = true;
                break;
            default:
                Console.WriteLine("Entered number is not within the range <1; 8>.");
                break;
        }
    }
}

void sum()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"{a} + {b} = {a + b}");
}

void difference()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"{a} - {b} = {a - b}");
}

void product()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"{a} * {b} = {a * b}");
}

void quotient()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"{a} / {b} = {a / b}");
}

void power()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
}

void root()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"{b}-th root of {a} = {Math.Pow(a, 1.0 / b)}");
}

void trigonometry()
{
    double angle_degree = DoubleInput();
    double angle_rad = angle_degree * Math.PI / 180;
    double sin, cos, tg, cot;
    sin = Math.Sin(angle_rad);
    cos = Math.Cos(angle_rad);
    tg = Math.Tan(angle_rad);
    cot = Math.Atan(tg);
    Console.WriteLine($"Entered angle in radians = {angle_rad},\n sin = {sin},\n cos = {cos},\n tg = {tg},\n cot = {cot}");
}

// excercise2();