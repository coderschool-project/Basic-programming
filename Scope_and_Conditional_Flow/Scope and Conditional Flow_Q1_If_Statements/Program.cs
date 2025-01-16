//Part 1
// Get two inputs from the userds and store them in two variables and use and if statement to check if the two inputs are equal and print out a message to the console.
// Hint: You can use the == operator to check if two values are equal.
Console.WriteLine("Part 1:");
Console.WriteLine("Enter first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secondNumber)
{
    Console.WriteLine("The two numbers are equal.");
}
else
{
    Console.WriteLine("The two numbers are not equal.");
}

//Part 2
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than the second input and print out a message to the console.
// Hint: You can use the > operator to check if the first input is greater than the second input.
Console.WriteLine("Part 2:");
Console.WriteLine("Enter first number:");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine("The first number is greater than the second number.");
}
else
{
    Console.WriteLine("The first number is not greater than the second number.");
}

//Part 3
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than the second input and print out a message to the console.
// Hint: You can use the < operator to check if the first input is less than the second input.

Console.WriteLine("Part 3:");
Console.WriteLine("Enter first number:");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber < secondNumber)
{
    Console.WriteLine("The first number is less than the second number.");
}
else
{
    Console.WriteLine("The first number is not less than the second number.");
}
//Part 4
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is not equal to the second input and print out a message to the console.
// Hint: You can use the != operator to check if two values are not equal.

Console.WriteLine("Part 4:");
Console.WriteLine("Enter first number:");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber != secondNumber)
{
    Console.WriteLine("The two numbers are not equal.");
}
else
{
    Console.WriteLine("The two numbers are equal.");
}

//Part 5
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than or equal to the second input and print out a message to the console.
// Hint: You can use the >= operator to check if the first input is greater than or equal to the second input.

Console.WriteLine("Part 5:");
Console.WriteLine("Enter first number:");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber >= secondNumber)
{
    Console.WriteLine("The first number is greater than or equal to the second number.");
}
else
{
    Console.WriteLine("The first number is not greater than or equal to the second number.");
}

//Part 6
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than or equal to the second input and print out a message to the console.
// Hint: You can use the <= operator to check if the first input is less than or equal to the second input.

Console.WriteLine("Part 6:");
Console.WriteLine("Enter first number:");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber <= secondNumber)
{
    Console.WriteLine("The first number is less than or equal to the second number.");
}
else
{
    Console.WriteLine("The first number is not less than or equal to the second number.");
}

//Part 7
// Create a math quiz that asks the user a math question and checks if the user's answer is correct. If the user's answer is correct, print out a message to the console. If the user's answer is incorrect, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user's answer is correct.

Console.WriteLine("Part 7:");
Console.WriteLine("What is 1 + 1?");
int answer = Convert.ToInt32(Console.ReadLine());
if (answer == 2)
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect!");
}


//Part 8
// Create a program that asks the user for their age and checks if the user is old enough to vote. If the user is old enough to vote, print out a message to the console. If the user is not old enough to vote, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user is old enough to vote.

Console.WriteLine("Part 8:");
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("You are old enough to vote.");
}
else
{
    Console.WriteLine("You are not old enough to vote.");
}


//Part 9
// Create a program that check whihc state a enemy is in based on their health points. If the enemy has 100 health points, print out a message to the console. If the enemy has 50 health points, print out a different message to the console. If the enemy has 25 health points, print out a different message to the console. If the enemy has 0 health points, print out a different message to the console.
// Hint: You can use an if-else statement to check the enemy's health points and print out a message based on the enemy's health points.

Console.WriteLine("Part 9:");
Console.WriteLine("Enter enemy's health points:");
int healthPoints = Convert.ToInt32(Console.ReadLine());
if (healthPoints == 100)
{
    Console.WriteLine("Enemy is at full health.");
}
else if (healthPoints == 50)
{
    Console.WriteLine("Enemy is at half health.");
}
else if (healthPoints == 25)
{
    Console.WriteLine("Enemy is at quarter health.");
}
else if (healthPoints == 0)
{
    Console.WriteLine("Enemy is defeated.");
}


//Part 10
// Create a program that checks if a user is eligible for a discount based on their age. If the user is 18 years old or older, print out a message to the console. If the user is younger than 18 years old, print out a different message to the console.
// Hint: You can use an if-else statement to check the user's age and print out a message based on the user's age.

Console.WriteLine("Part 10:");
Console.WriteLine("Enter your age:");
age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("You are eligible for a discount.");
}
else
{
    Console.WriteLine("You are not eligible for a discount.");
}






////////////// Break , Continue Statements //////////////


//Part 1
// Create a program that counts from 1 to 20, but skips counting the number 5.
// Hint: Use a for loop to iterate through the numbers and a continue statement to skip the number 5.

Console.WriteLine("Part 1:");
for (int i = 1; i <= 20; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}

//Part 2
// Create a program that prints the numbers from 1 to 10, but breaks the loop if the number 7 is encountered.
// Hint: Use a for loop to iterate through the numbers and a break statement to exit the loop when 7 is encountered.

Console.WriteLine("Part 2:");
for (int i = 1; i <= 10; i++)
{
    if (i == 7)
    {
        break;
    }
    Console.WriteLine(i);
}

//Part 3
// Write a program to print all even numbers from 1 to 20, but skip printing the number 10.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 10.

Console.WriteLine("Part 3:");
for (int i = 1; i <= 20; i++)
{
    if (i == 10)
    {
        continue;
    }
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//Part 4
// Create a program that searches for the word "apple" in a list of fruits. If found, print "Apple found!"; otherwise, continue searching.
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement to check if the current fruit is "apple". Use a continue statement to continue searching if "apple" is not found.

Console.WriteLine("Part 4:");
string[] fruits = { "apple", "banana", "orange", "grape", "mango" };
foreach (string fruit in fruits)
{
    if (fruit != "apple")
    {
        continue;
    }
    Console.WriteLine("Apple found!");
}

//Part 5
// Write a program to count from 1 to 100, but skip counting by 10s.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip counting by 10s.

Console.WriteLine("Part 5:");
for (int i = 1; i <= 100; i++)
{
    if (i % 10 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}

//Part 6
// Create a program to print the letters of the alphabet from A to G, but skip printing the letter 'E'.
// Hint: Use a for loop to iterate through the alphabet and an if statement with a continue statement to skip printing 'E'.

Console.WriteLine("Part 6:");
for (char i = 'A'; i <= 'G'; i++)
{
    if (i == 'E')
    {
        continue;
    }
    Console.WriteLine(i);
}

//Part 7
// Write a program to find and print all prime numbers between 1 and 50, skipping non-prime numbers.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip non-prime numbers.

Console.WriteLine("Part 7:");
bool isPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}
for (int i = 1; i <= 50; i++)
{
    if (!isPrime(i))
    {
        continue;
    }
    Console.WriteLine(i);
}


//Part 8
// Create a program to print the numbers from 1 to 10, but skip printing the number 3.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 3.

Console.WriteLine("Part 8:");
for (int i = 1; i <= 10; i++)
{
    if (i == 3)
    {
        continue;
    }
    Console.WriteLine(i);
}

//Part 9
// Write a program to search for the number 20 in an array of integers. If found, print its index; otherwise, continue searching.
// Hint: Use a for loop to iterate through the array and an if statement to check if the current element is 20. Use a continue statement to continue searching if 20 is not found.

Console.WriteLine("Part 9:");
int[] numbers = { 10, 15, 20, 25, 30 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] != 20)
    {
        continue;
    }
    Console.WriteLine("Index of 20: " + i);
}

//Part 10
// Create a program that prints the names of different fruits, but skips printing the name "banana".
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement with a continue statement to skip printing "banana".

Console.WriteLine("Part 10:");
fruits = new string[] { "apple", "banana", "orange", "grape", "mango" };
foreach (string fruit in fruits)
{
    if (fruit == "banana")
    {
        continue;
    }
    Console.WriteLine(fruit);
}





////////////// Extra Challenges //////////////

/*
Part 11

ABC Company pays its sales agents on a commission basis. 
Each agent is paid 10% commission for monthly sales above or equal to $10,000 and 5% commission for monthly sales below $10,000.

Write a program to accept the monthly sales of a particular agent and based on the amount, determine and print out the commission earned.

Example:
Enter the monthly sales: 12000
Commission earned: $1200.00

*/

Console.WriteLine("Part 11:");
Console.WriteLine("Enter the monthly sales:");
double sales = Convert.ToDouble(Console.ReadLine());
double commission = 0;
if (sales >= 10000)
{
    commission = sales * 0.10;
}
else
{
    commission = sales * 0.05;
}
Console.WriteLine("Commission earned: $" + commission.ToString("F2"));


/*
Part 12

Write a program that generates two integers between 0 and 100 inclusive and prompts the user to enter the sum of these 2 integers. The program reports if the answer is correct or wrong (program will also print the correct answer if the user's answer is wrong).

Hint: You need to use the random module.

Example:
Enter the sum of 43 and 58: 100
Correct!

 */

Console.WriteLine("Part 12:");
Random random = new Random();
int number1 = random.Next(0, 101);
int number2 = random.Next(0, 101);
Console.WriteLine("Enter the sum of " + number1 + " and " + number2 + ":");
int sum = Convert.ToInt32(Console.ReadLine());
if (sum == number1 + number2)
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Wrong! The correct answer is " + (number1 + number2));
}



/*
 Part 13

The grade that you get for a module depends on your marks. The table below shows the grade for each range of marks.

Marks   |   Grade   |   Comment
---------------------------------
>= 85   |     A+    |  Excellent!
>= 80   |     A     |  Well done.
>= 75   |     B+    |
>= 70   |     B     |
>= 65   |     C+    |
>= 60   |     C     |
>= 55   |     D+    |
>= 50   |     D     |
< 50    |     F     |  See me.

Write a program that asks for a student’s marks, then displays the correct grade and the corresponding comment (if any).

Example:
Enter student's marks: 82
Grade: A
Comment: Well done.
 

 
 */

Console.WriteLine("Part 13:");
Console.WriteLine("Enter student's marks:");
int marks = Convert.ToInt32(Console.ReadLine());
string grade;
string comment = "";

if (marks >= 85)
{
    grade = "A+";
    comment = "Excellent!";
}
else if (marks >= 80)
{
    grade = "A";
    comment = "Well done.";
}
else if (marks >= 75)
{
    grade = "B+";
}
else if (marks >= 70)
{
    grade = "B";
}
else if (marks >= 65)
{
    grade = "C+";
}
else if (marks >= 60)
{
    grade = "C";
}
else if (marks >= 55)
{
    grade = "D+";
}
else if (marks >= 50)
{
    grade = "D";
}
else
{
    grade = "F";
    comment = "See me.";
}
Console.WriteLine("Grade: " + grade);
Console.WriteLine("Comment: " + comment);

/*
 Part 14

 A guard in a computer game acts as follows:

If sees_player == False, he will wait

If sees_player == True:
    - If dist_from_player <= 1, he will attack
    - If 2 <= dist_from_player <= 4, he will advance
    - If dist_from_player >= 5, he will wait

Write a program that shows how the guard will act.

Example:
sees_player = True
dist_from_player = 3

The guard will advance.

 
 
 */

Console.WriteLine("Part 14:");
Console.WriteLine("Enter sees_player:");
bool seesPlayer = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Enter dist_from_player:");
int distFromPlayer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sees_player = " + seesPlayer);
Console.WriteLine("dist_from_player = " + distFromPlayer);
if (seesPlayer)
{
    if (distFromPlayer <= 1)
    {
        Console.WriteLine("The guard will attack.");
    }
    else if (distFromPlayer <= 4)
    {
        Console.WriteLine("The guard will advance.");
    }
    else
    {
        Console.WriteLine("The guard will wait.");
    }
}
else
{
    Console.WriteLine("The guard will wait.");
}
