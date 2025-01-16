//Part 1
// Use the Math class to calculate the minimum of two numbers.
// Hint: Use the Min method of the Math class.
// Test Data:
// Enter the first number: 5
// Enter the second number: 10
// Expected Output:
// The minimum of 5 and 10 is 5
Console.WriteLine("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The minimum of " + firstNumber + " and " + secondNumber + " is " + Math.Min(firstNumber, secondNumber));

//Part 2
// Use the Math class to calculate the maximum of two numbers.
// Hint: Use the Max method of the Math class.
// Test Data:
// Enter the first number: 15
// Enter the second number: 8
// Expected Output:
// The maximum of 15 and 8 is 15
Console.WriteLine("Enter the first number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The maximum of " + firstNumber + " and " + secondNumber + " is " + Math.Max(firstNumber, secondNumber));

//Part 3
// Use the Math class to calculate the square root of a number.
// Hint: Use the Sqrt method of the Math class.
// Test Data:
// Enter a number: 144
// Expected Output:
// The square root of 144 is 12
Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The square root of " + number + " is " + Math.Sqrt(number));


//Part 4
// Use the Math class to calculate the absolute value of a number.
// Hint: Use the Abs method of the Math class.
// Test Data:
// Enter a number: -5
// Expected Output:
// The absolute value of -5 is 5

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The absolute value of " + number + " is " + Math.Abs(number));


//Part 5
// Use the Math class to calculate the power of a number.
// Hint: Use the Pow method of the Math class.
// Test Data:
// Enter the base number: 2
// Enter the exponent: 5
// Expected Output:
// 2 raised to the power of 5 is 32

Console.WriteLine("Enter the base number: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the exponent: ");
int exponent = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(baseNumber + " raised to the power of " + exponent + " is " + Math.Pow(baseNumber, exponent));

//Part 6
// Use the Math class to round a number to the nearest integer.
// Hint: Use the Round method of the Math class.
// Test Data:
// Enter a number: 4.6
// Expected Output:
// 4.6 rounded to the nearest integer is 5

Console.WriteLine("Enter a number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(number + " rounded to the nearest integer is " + Math.Round(number));

//Part 7
// Use the Math class to find the smallest integer greater than or equal to a number.
// Hint: Use the Ceiling method of the Math class.
// Test Data:
// Enter a number: 3.14
// Expected Output:
// The smallest integer greater than or equal to 3.14 is 4

Console.WriteLine("Enter a number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The smallest integer greater than or equal to " + number + " is " + Math.Ceiling(number));


//Part 8
// Use the Math class to find the largest integer less than or equal to a number.
// Hint: Use the Floor method of the Math class.
// Test Data:
// Enter a number: 3.14
// Expected Output:
// The largest integer less than or equal to 3.14 is 3

Console.WriteLine("Enter a number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The largest integer less than or equal to " + number + " is " + Math.Floor(number));

//Part 9
// Use the Math class to calculate e raised to the power of a number.
// Hint: Use the Exp method of the Math class.
// Test Data:
// Enter a number: 2
// Expected Output:
// e raised to the power of 2 is 7.38905609893065

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("e raised to the power of " + number + " is " + Math.Exp(number));

//Part 10
// Use the Math class to calculate the natural logarithm of a number.
// Hint: Use the Log method of the Math class.
// Test Data:
// Enter a number: 100
// Expected Output:
// The natural logarithm of 100 is 4.60517018598809

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The natural logarithm of " + number + " is " + Math.Log(number));

//Part 11
// Generate a random number between 1 and 100 using the Math class.
// Hint: Use the Random method of the Math class.
// Expected Output:
// A random number between 1 and 100 is 56

Random random = new Random();
int randomNumber = random.Next(1, 101);
Console.WriteLine("A random number between 1 and 100 is " + randomNumber);
