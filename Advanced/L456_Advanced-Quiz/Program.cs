
/*
Question 1:
BMI Calculation

The Body Mass Index (BMI) of a person is calculated based on the following formula: 
BMI = weight / (height x height)

Note:
- weight is in kilograms (e.g. 65.0)
- height is in metres (e.g. 1.70)

Write a C# program to:
- prompt the user to enter his/her weight and height
- calculate the BMI (body mass index)
- display the BMI and the health category according to the table below:

BMI Health category
Below 18.5    Underweight
18.5 - 23     Normal weight
23 - 27.5     Overweight
Above 27.5    Obese
*/
void BMICalculation()
{
    Console.WriteLine("Enter your weight in kilograms: ");
    double weight = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter your height in meters: ");
    double height = Convert.ToDouble(Console.ReadLine());
    double bmi = weight / (height * height);
    if (bmi <= 18.5)
    {
        Console.WriteLine("Underweight");
    }
    else if (bmi <= 23)
    {
        Console.WriteLine("Normal weight");
    }
    else if (bmi <= 27.5)
    {
        Console.WriteLine("Overweight");
    }
    else
    {
        Console.WriteLine("Obese");
    }

}











/*
Question 2:
Discount Calculation [using if..else]

The discount rate given by a shopping mall is shown below:
----------------------------------------------
| Amount spent ($)      |  Discount Rate (%) |
| 100 and below         |        0           |
| 100 < amount <= 500   |        5           |
| 500 < amount <= 1000  |       10           |
| Above 1000            |       20           |
----------------------------------------------
Write a C# program to:
- prompt the user to enter the amount spent 
- calculate and display the discount given (in percentage)
- calculate and display the discount amount
*/
void DiscountCalculation()
{
    Console.WriteLine("Enter the amount spent: ");
    double amount = Convert.ToDouble(Console.ReadLine());
    double discountRate = 0;
    if (amount > 100 && amount <= 500)
    {
        discountRate = 5;
    }
    else if (amount > 500 && amount <= 1000)
    {
        discountRate = 10;
    }
    else if (amount > 1000)
    {
        discountRate = 20;
    }
    Console.WriteLine("Discount rate: " + discountRate);
    Console.WriteLine("Discount amount: " + (amount * discountRate / 100));
}








/*
Question 3:
Multiplication Table [using repetition structure]

Write a C# program to display the multiplication table for a given number from 1 to 12.

Example:
Enter a number : 8
1  8
2  16
3  24
4  32
5  40
6  48
7  56
8  64
9  72
10 80
11 88
12 96
*/
void CreateMultiplicationTable()
{
    Console.WriteLine("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine(number + " x " + i + " = " + number * i);
    }
}




/*
Question 4:
Admin Menu [using methods, loop & nested if]

Write a C# program that displays the main menu and allows the user to select options to perform BMI calculation, discount calculation, or display a multiplication table. The program should repeatedly display the menu until the user chooses to exit.

Example:
------------- MENU --------------
[1] Calculate Body Mass Index
[2] Calculate Discount
[3] Display Multiplication Table
[0] Exit
---------------------------------
*/
void AdminMenu()
{
    Console.WriteLine("------------- MENU --------------");
    Console.WriteLine("[1] Calculate Body Mass Index");
    Console.WriteLine("[2] Calculate Discount");
    Console.WriteLine("[3] Display Multiplication Table");
    Console.WriteLine("[0] Exit");
    Console.WriteLine("---------------------------------");
    int option = 0;
    while (option != 0)
    {
        Console.WriteLine("Enter your option: ");
        option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                BMICalculation();
                break;
            case 2:
                DiscountCalculation();
                break;
            case 3:
                CreateMultiplicationTable();
                break;
            case 0:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}

AdminMenu();







/*
Question 5:
Write a program that adds up to 5 unique words to a list. 
The user can enter ‘x’ to stop adding words. 
Once either 5 words are added or the user stops the program early, 
the words are listed and the total number of letters in the words are displayed.

Example:
Enter a word (or 'x' to stop): apple
Enter a word (or 'x' to stop): banana
Enter a word (or 'x' to stop): orange
Enter a word (or 'x' to stop): x

List of words:
- apple
- banana
- orange

Total number of letters: 16
*/

void WordList()
{
    List<string> words = new List<string>();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Enter a word (or 'x' to stop): ");
        string word = Console.ReadLine();
        if (word == "x")
        {
            break;
        }
        words.Add(word);
    }
    Console.WriteLine("List of words:");
    foreach (string word in words)
    {
        Console.WriteLine("- " + word);
    }
    Console.WriteLine("Total number of letters: " + words.Sum(word => word.Length));
}

WordList();



/*
Question 6:
Write a program that simulates a number guessing game. 
It first generates a random number between 1 and 100. 
It then prompts the user to guess the correct number. 
The user can enter -1 to end the game, or the game will end after 5 tries.


Example:
Guess the number (between 1 and 100, or enter -1 to quit): 50
Too high!
Guess the number (between 1 and 100, or enter -1 to quit): 25
Too low!
Guess the number (between 1 and 100, or enter -1 to quit): 37
Too high!
Guess the number (between 1 and 100, or enter -1 to quit): 30
Congratulations! You guessed the correct number in 4 tries.

*/

void NumberGuessingGame()
{
    Random random = new Random();
    int number = random.Next(1, 101);
    int tries = 0;
    while (number != -1 && tries < 5)
    {
        Console.WriteLine("Guess the number (between 1 and 100, or enter -1 to quit): ");
        int guess = Convert.ToInt32(Console.ReadLine());
        if (guess == -1)
        {
            Console.WriteLine("Game ended.");
            break;
        }
        else if (guess > number)
        {
            Console.WriteLine("Too high!");
        }
        else if (guess < number)
        {
            Console.WriteLine("Too low!");
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the correct number in " + tries + " tries.");
            break;
        }
        tries++;
    }
}

NumberGuessingGame();


