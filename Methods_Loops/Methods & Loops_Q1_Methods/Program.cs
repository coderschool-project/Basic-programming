//---------------------------------------------------------------------
// Part 1: Displaying a Welcome Message
// Create a user-defined function to display a welcome message.
// Hint: Define a function named DisplayWelcomeMessage() that prints the welcome message to the console.

void DisplayWelcomeMessage()
{
    Console.WriteLine("Welcome to the CoderSchool!");
}
DisplayWelcomeMessage();

//---------------------------------------------------------------------
// Part 2: Personalized Welcome Message
// Create a user-defined function with parameters to personalize a welcome message.
// Hint: Define a function named PersonalizedWelcomeMessage() that takes a name as a parameter and prints a personalized welcome message to the console.

void PersonalizedWelcomeMessage(string name)
{
    Console.WriteLine("Welcome, " + name + "!");
}
PersonalizedWelcomeMessage("John");
//---------------------------------------------------------------------
// Part 3: Calculating the Sum of Two Numbers
// Create a user-defined function to calculate the sum of two numbers.
// Hint: Define a function named CalculateSum() that takes two parameters, adds them, and returns the result.

int CalculateSum(int num1, int num2)
{
    return num1 + num2;
}
Console.WriteLine(CalculateSum(5, 7));

//---------------------------------------------------------------------
// Part 4: Counting Spaces in a String
// Create a user-defined function to count the number of spaces in a string.
// Hint: Define a function named CountSpaces() that takes a string as a parameter, counts the number of spaces, and returns the count.

int CountSpaces(string str)
{
    int count = 0;
    foreach (char c in str)
    {
        if (c == ' ')
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(CountSpaces("Hello, world!"));

//---------------------------------------------------------------------
// Part 5: Calculating the Sum of Elements in an Array
// Create a user-defined function to calculate the sum of elements in an array.
// Hint: Define a function named CalculateArraySum() that takes an array as a parameter, calculates the sum of its elements, and returns the sum.

int CalculateArraySum(int[] arr)
{
    int sum = 0;
    foreach (int num in arr)
    {
        sum += num;
    }
    return sum;
}

int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(CalculateArraySum(numbers));
//---------------------------------------------------------------------
// Part 6: Swapping Two Integer Numbers
// Create a user-defined function to swap two integer numbers.
// Hint: Define a function named SwapNumbers() that takes two integer parameters, swaps their values, and prints the updated values to the console.

void SwapNumbers(ref int num1, ref int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
    Console.WriteLine("After swapping: num1 = " + num1 + ", num2 = " + num2);
}

int a = 5;
int b = 10;
Console.WriteLine("Before swapping: num1 = " + a + ", num2 = " + b);
SwapNumbers(ref a, ref b);


//---------------------------------------------------------------------
// Part 7: Calculating Exponentiation
// Create a user-defined function to calculate the result of raising an integer number to another.
// Hint: Define a function named CalculateExponent() that takes two integer parameters (base and exponent), calculates the result, and prints it to the console.

int CalculateExponent(int num, int exp)
{
    int result = 1;
    for (int i = 0; i < exp; i++)
    {
        result *= num;
    }
    return result;
}

Console.WriteLine(CalculateExponent(2, 3));

//---------------------------------------------------------------------
// Part 8: Displaying the Fibonacci Sequence
// Create a user-defined function to display the Fibonacci sequence up to a specified number of terms.
// Hint: Define a function named DisplayFibonacciSequence() that takes an integer parameter (number of terms), calculates and prints the Fibonacci sequence to the console.

void DisplayFibonacciSequence(int numTerms)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < numTerms; i++)
    {
        Console.Write(a + " ");
        int temp = a;
        a = b;
        b = temp + b;
    }
}

DisplayFibonacciSequence(10);

//---------------------------------------------------------------------
// Part 9: Checking Prime Numbers
// Create a user-defined function to check whether a number is prime or not.
// Hint: Define a function named CheckPrimeNumber() that takes an integer parameter, checks if it's prime, and prints the result to the console.

bool CheckPrimeNumber(int num)
{
    if (num <= 1)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine(CheckPrimeNumber(7));

//---------------------------------------------------------------------
// Part 10: Calculating the Sum of Individual Digits
// Create a user-defined function to calculate the sum of individual digits of a given number.
// Hint: Define a function named CalculateDigitSum() that takes an integer parameter, calculates the sum of its digits, and prints the result to the console.

int CalculateDigitSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine(CalculateDigitSum(12345));

//---------------------------------------------------------------------
// Part 11: Testing Named Parameters in C#
// Write a C# program that defines a method called "DisplayInfo" that takes two parameters: "name" and "age".
// Use named parameters to call the "DisplayInfo" method with the parameter values "name"="John" and "age"=30.
// Hint: Define the method "DisplayInfo" with parameters "name" and "age", then call it using named parameters.

void DisplayInfo(string name, int age)
{
    Console.WriteLine("Name: " + name);
    Console.WriteLine("Age: " + age);
}

DisplayInfo(name: "John", age: 30);

//---------------------------------------------------------------------
// Part 12: Testing Out Parameters in C#
// Write a C# program that defines a method called "GetSquareRoot" that calculates the square root of a number.
// Use an out parameter to return the square root of a given number.
// Hint: Define the method "GetSquareRoot" with an out parameter to store the result.

double GetSquareRoot(double num, out double result)
{
    result = Math.Sqrt(num);
    return result;
}

double number = 16;
double squareRoot;
Console.WriteLine("The square root of " + number + " is: " + GetSquareRoot(number, out squareRoot));

//---------------------------------------------------------------------
// Part 13: Testing Default or Optional Parameters in C#
// Write a C# program that defines a method called "GreetUser" with two parameters: "name" and "greetingMessage".
// Set the default value of "greetingMessage" to "Hello".
// Call the "GreetUser" method with only the "name" parameter provided.
// Hint: Define the method "GreetUser" with a default value for one of its parameters.

void GreetUser(string name, string greetingMessage = "Hello")
{
    Console.WriteLine(greetingMessage + ", " + name + "!");
}

GreetUser("John");