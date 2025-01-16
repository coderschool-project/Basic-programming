// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.
using System.Globalization;

NumberFormatInfo setPrecision = new NumberFormatInfo();
setPrecision.NumberDecimalDigits = 1;


//Part 1

// Create a program to get the users height in meters and weight in kilograms and calculate the BMI of the user.
// The formula to calculate the BMI is weight / (height * height).
// The program should then display the BMI of the user and display the following message based on the BMI:
// BMI < 18.5: Underweight
// 18.5 <= BMI < 25: Normal
// 25 <= BMI < 30: Overweight
// BMI >= 30: Obese

//Test Data
//Enter your height in meters: 1.75
//Enter your weight in kilograms: 68
//Your BMI is 22.2
//You are Normal

Console.WriteLine("Part 1:");
Console.WriteLine("Enter your height in meters:");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your weight in kilograms:");
double weight = Convert.ToDouble(Console.ReadLine());
double bmi = weight / (height * height);
if (bmi <= 0)
{
    Console.WriteLine("Invalid Input");
}
else if (bmi < 18.5)
{
    Console.WriteLine("You are Underweight");
}
else if (bmi < 25)
{
    Console.WriteLine("You are Normal");
}
else if (bmi < 30)
{
    Console.WriteLine("You are Overweight");
}
else
{
    Console.WriteLine("You are Obese");
}



//Part 2

// Modify the program to get the users height in feet and inches and weight in pounds and calculate the BMI of the user.
// The formula to calculate the BMI is (weight * 703) / (height * height).
// The program should then display the BMI of the user and display the following message based on the BMI:
// BMI < 18.5: Underweight
// 18.5 <= BMI < 25: Normal
// 25 <= BMI < 30: Overweight
// BMI >= 30: Obese

//Test Data
//Enter your height in feet: 5
//Enter your height in inches: 9
//Enter your weight in pounds: 150
//Your BMI is 22.1
//You are Normal

Console.WriteLine("Part 2:");
Console.WriteLine("Enter your height in feet:");
double heightFeet = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your height in inches:");
double heightInches = Convert.ToDouble(Console.ReadLine());
height = (heightFeet * 12) + heightInches;
Console.WriteLine("Enter your weight in pounds:");
weight = Convert.ToDouble(Console.ReadLine());
bmi = (weight * 703) / (height * height);
if (bmi <= 0)
{
    Console.WriteLine("Invalid Input");
}
else if (bmi < 18.5)
{
    Console.WriteLine("You are Underweight");
}
else if (bmi < 25)
{
    Console.WriteLine("You are Normal");
}
else if (bmi < 30)
{
    Console.WriteLine("You are Overweight");
}
else
{
    Console.WriteLine("You are Obese");
}
//Part 3

//In a game, the player's score is stored as an integer, but you need to display it with one decimal place. Convert the player's score from an integer to a double and print the result.

//Test Data
//Player's Score: 100
//Player's Score with one decimal place: 100.0

Console.WriteLine("Part 3:");
Console.WriteLine("Enter your score:");
int score = Convert.ToInt32(Console.ReadLine());
double scoreWithOneDecimalPlace = Convert.ToDouble(score);
Console.WriteLine("Your score with one decimal place: " + scoreWithOneDecimalPlace.ToString("N", setPrecision));

//Part 4
//In a game, the player's health is stored as a double, but you need to display it as a percentage (integer value). Convert the player's health from a double to an integer representing a percentage and print the result.

//Test Data
//Player's Health: 0.75
//Player's Health as a percentage: 75%

Console.WriteLine("Part 4:");
Console.WriteLine("Enter your health:");
double health = Convert.ToDouble(Console.ReadLine());
int percentage = (int)(health * 100);
Console.WriteLine("Your health as a percentage: " + percentage + "%");



//Part 5

//In a game, the player's coins are stored as a double, but you need to display them as an integer (rounded down). Convert the player's coins from a double to an integer and print the result.

//Test Data
//Player's Coins: 123.45
//Player's Coins as an integer: 123

Console.WriteLine("Part 5:");
Console.WriteLine("Enter your coins:");
double coins = Convert.ToDouble(Console.ReadLine());
int coinsAsAnInteger = (int)coins;
Console.WriteLine("Your coins as an integer: " + coinsAsAnInteger);


//Part 6

//In a game, the player's progress is stored as a boolean (true for completed, false for incomplete), but you need to display it as a string ("Completed" or "Incomplete").
//Convert the player's progress from a boolean to a string representing the status and print the result.
//Hint: Use a conditional statement to check the boolean value and return the appropriate string. e.g ., if (progress) { return "Completed"; } else { return "Incomplete"; }

//Test Data
//Player's Progress: true
//Player's Progress as a string: Completed

Console.WriteLine("Part 6:");
bool progress = Convert.ToBoolean(Console.ReadLine());
if (progress)
{
    Console.WriteLine("Completed");
}
else
{
    Console.WriteLine("Incomplete");
}




