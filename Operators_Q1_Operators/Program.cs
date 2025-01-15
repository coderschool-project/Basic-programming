﻿// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.

//---------------------------------------------------------------------
// Part 1: Mathematical Operators
// Write a C# program to print the sum of two numbers.
// Hint: You can use the + operator to add two numbers.
// Test data: int num1 = 10, int num2 = 5
Console.WriteLine("Part 1:");
int num1 = 10;
int num2 = 5;
Console.WriteLine(num1 + num2);

//---------------------------------------------------------------------
// Part 2: Mathematical Operators
// Write a C# program to print the difference between two numbers.
// Hint: You can use the - operator to subtract two numbers.
// Test data: int num1 = 10, int num2 = 5
Console.WriteLine("Part 2:");
Console.WriteLine(num1 - num2);

//---------------------------------------------------------------------
// Part 3: Mathematical Operators
// Write a C# program to print the product of two numbers.
// Hint: You can use the * operator to multiply two numbers.
// Test data: int num1 = 10, int num2 = 5
Console.WriteLine("Part 3:");
Console.WriteLine(num1 * num2);

//---------------------------------------------------------------------
// Part 4: Mathematical Operators
// Write a C# program to print the division of two numbers.
// Hint: You can use the / operator to divide two numbers.
// Test data: int num1 = 10, int num2 = 5
Console.WriteLine("Part 4:");
Console.WriteLine(num1 / num2);


//---------------------------------------------------------------------
// Part 5: Mathematical Operators
// Write a C# program to print the remainder of two numbers.
// Hint: You can use the % operator to find the remainder of two numbers.
// Test data: int num1 = 10, int num2 = 5
Console.WriteLine("Part 5:");
Console.WriteLine(num1 % num2);



//---------------------------------------------------------------------
// Part 6: Mathematical Operators
// Write a C# program to calculate the square of a number.
// Hint: You can use the * operator to multiply a number by itself.
// Test data: int num = 5
Console.WriteLine("Part 6:");
int num = 5;
Console.WriteLine(num * num);

//---------------------------------------------------------------------
// Part 7: Mathematical Operators
// Write a C# program to calculate the average of two numbers.
// Hint: You can add the two numbers together and then divide the sum by 2 to find the average.
// Test data: int num1 = 10, int num2 = 20
Console.WriteLine("Part 7:");
num1 = 10;
num2 = 20;
Console.WriteLine((num1 + num2) / 2);


//---------------------------------------------------------------------
// Part 8: Mathematical Operators
// Write a C# program to calculate the average of three numbers.
// Hint: You can add the three numbers together and then divide the sum by 3 to find the average.
// Test data: int num1 = 10, int num2 = 20, int num3 = 30
Console.WriteLine("Part 8:");
int num3 = 30;
Console.WriteLine((num1 + num2 + num3) / 3);


//---------------------------------------------------------------------
// Part 9: Mathematical Operators
// Write a C# program to convert temperature from Celsius to Fahrenheit.
// Hint: Use the formula (Celsius * 9/5) + 32.
// Test data: double celsius = 20
Console.WriteLine("Part 9:");
double celsius = 20;
Console.WriteLine((celsius * 9 / 5) + 32);


//---------------------------------------------------------------------
// Part 10: Mathematical Operators
// Write a C# program to calculate the area of a rectangle given its length and width.
// Hint: Use the formula area = length * width.
// Test data: double length = 10, double width = 5
Console.WriteLine("Part 10:");
double length = 10;
double width = 5;
Console.WriteLine(length * width);



//---------------------------------------------------------------------
// Part 11: Mathematical Operators
// Write a C# program to calculate the volume of a sphere given its radius.
// Hint: Use the formula volume = (4/3) * Pi * radius^3.
// Test data: double radius = 5
Console.WriteLine("Part 11:");
double radius = 5;
const double Pi = 3.14159;
Console.WriteLine((4 / 3) * Pi * Math.Pow(radius, 3));



//---------------------------------------------------------------------
// Part 12: Mathematical Operators
// Write a C# program to calculate the factorial of a given integer.
// Hint: Use a loop to multiply the numbers from 1 to the given integer.
// Test data: int num = 5
Console.WriteLine("Part 12:");
num = 5;
int factorial = 1;
for (int i = 1; i <= num; i++)
{
    factorial *= i;
}


//---------------------------------------------------------------------
// Part 13: Mathematical Operators
// Write a C# program to calculate the compound interest given the principal amount, interest rate, and time period.
// Hint: Use the formula A = P * (1 + r/n)^(nt).
// Test data: double principal = 1000, double rate = 0.05, int time = 5
Console.WriteLine("Part 13:");
double principal = 1000;
double rate = 0.05;
int time = 5;
double compoundInterest = principal * Math.Pow((1 + rate), time);
Console.WriteLine(compoundInterest);


//---------------------------------------------------------------------
// Part 14: Mathematical Operators
// Write a C# program to solve a quadratic equation of the form ax^2 + bx + c = 0.
// Hint: Use the quadratic formula.
// Test data: double a = 1, double b = 5, double c = 6
Console.WriteLine("Part 14:");
double a = 1;
double b = 5;
double c = 6;
double discriminant = Math.Pow(b, 2) - 4 * a * c;
if (discriminant > 0)

{
    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine("The roots are {0} and {1}", root1, root2);
}
else if (discriminant == 0)
{
    double root = -b / (2 * a);
    Console.WriteLine("The root is {0}", root);
}
else
{
    Console.WriteLine("No real roots");
}


//---------------------------------------------------------------------
// Part 15: Mathematical Operators
// Write a C# program to calculate the nth Fibonacci number using recursion.
// Hint: Use a recursive function to calculate Fibonacci numbers.
// Test data: int n = 8
Console.WriteLine("Part 15:");
int n = 8;

int fibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return fibonacci(n - 1) + fibonacci(n - 2);
    }
}

Console.WriteLine(fibonacci(n));

//---------------------------------------------------------------------
// Part 16: Mathematical Operators
// Write a C# program to calculate the nth term of the arithmetic sequence given the first term, common difference, and term number.
// Hint: Use the formula nth term = first term + (n - 1) * common difference.
// Test data: int firstTerm = 3, int commonDifference = 2, int termNumber = 5
Console.WriteLine("Part 16:");
int firstTerm = 3;
int commonDifference = 2;
int termNumber = 5;
int nthTerm = firstTerm + (termNumber - 1) * commonDifference;
Console.WriteLine(nthTerm);

//---------------------------------------------------------------------
// Part 17: Relational Operators
// Write a C# program to check if a given number is greater than another number.
// Hint: Use the > operator to check if the first number is greater than the second number.
// Test data: int num1 = 10, int num2 = 5
Console.WriteLine("Part 17:");
num1 = 10;
num2 = 5;
if (num1 > num2)
{
    Console.WriteLine("num1 is greater than num2");
}
else
{
    Console.WriteLine("num1 is not greater than num2");
}

//---------------------------------------------------------------------
// Part 18: Relational Operators
// Write a C# program to check if a given number is less than or equal to 100.
// Prompt the user to enter a number and check if it is less than or equal to 100.
// Hint: Use the <= operator to check if the number is less than or equal to 100.
// Test data: Enter a number: 88
Console.WriteLine("Part 18:");
Console.WriteLine("Enter a number:");
num = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
if (num <= 100)
{
    Console.WriteLine("The number is less than or equal to 100");
}
else
{
    Console.WriteLine("The number is not less than or equal to 100");
}

//---------------------------------------------------------------------
// Part 19: Logical Operators
// Write a C# program to check if a given number is even AND greater than 10.
// Prompt the user to enter a number and check if it satisfies both conditions.
// Hint: Use the % operator to check if the number is even, and the && operator to check both conditions.
// Test data: Enter a number: 16
Console.WriteLine("Part 19:");
Console.WriteLine("Enter a number:");
num = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
if (num % 2 == 0 && num > 10)
{
    Console.WriteLine("The number is even and greater than 10");
}
else
{
    Console.WriteLine("The number is not even and greater than 10");
}

//---------------------------------------------------------------------
// Part 20: Logical Operators
// Write a C# program to check if a given number is divisible by 3 OR 5.
// Prompt the user to enter a number and check if it is divisible by either 3 or 5.
// Hint: Use the % operator to check for divisibility, and the || operator to check either condition.
// Test data: Enter a number: 9
Console.WriteLine("Part 20:");
Console.WriteLine("Enter a number:");
num = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
if (num % 3 == 0 || num % 5 == 0)
{
    Console.WriteLine("The number is divisible by 3 or 5");
}
else
{
    Console.WriteLine("The number is not divisible by 3 or 5");
}


//---------------------------------------------------------------------
// Part 21: Initialization and Assignment Operators
// Write a C# program to increment a variable by 5 using the shorthand assignment operator.
// Prompt the user to enter a number and increment it by 5 using the shorthand assignment operator.
// Hint: Use the += operator to increment the variable by 5.
// Test data: Enter a number: 7
Console.WriteLine("Part 21:");
Console.WriteLine("Enter a number:");
num = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
num += 5;
Console.WriteLine(num);

//---------------------------------------------------------------------
// Part 22: Initialization and Assignment Operators
// Write a C# program to calculate the remainder when dividing a number by 7 and update the number using the %= operator.
// Initialize a variable 'number' with a value of 27, then calculate the remainder when dividing 'number' by 7 and update 'number' with the result.
// Hint: Use the %= operator to update the value of 'number' with the remainder of 'number' divided by 7.
// Test data: int number = 27
Console.WriteLine("Part 22:");
int number = 27;
number %= 7;
Console.WriteLine(number);



