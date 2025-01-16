////////////////While Loop////////////////

//Part 1
//Create a program that uses a while loop to print out the numbers 1 to 10 to the console.
//Hint: You can use a while loop to print out the numbers 1 to 10 to the console.

Console.WriteLine("Part 1:");
int i = 1;
while (i <= 10)
{
    Console.WriteLine(i);
    i++;
}

//Part 2
//Create a program that uses a while loop to print out the numbers 10 to 1 to the console.
//Hint: You can use a while loop to print out the numbers 10 to 1 to the console.

Console.WriteLine("Part 2:");
i = 10;
while (i > 0)
{
    Console.WriteLine(i);
    i--;
}


//Part 3
//Create a program that uses a while loop to print out the even numbers from 1 to 10 to the console.
//Hint: You can use a while loop to print out the even numbers from 1 to 10 to the console.

Console.WriteLine("Part 3:");
i = 2;
while (i <= 10)
{
    Console.WriteLine(i);
    i += 2;
}



//Part 4
//Create a program that uses a while loop to print out the odd numbers from 1 to 10 to the console.
//Hint: You can use a while loop to print out the odd numbers from 1 to 10 to the console.

Console.WriteLine("Part 4:");
i = 1;
while (i <= 10)
{
    Console.WriteLine(i);
    i += 2;
}


//Part 5
//Write a C# Sharp program that takes a number as input and print its multiplication table.
//Hint: You can use a while loop to print out the multiplication table of a number.
//Test Data:
//Enter the number: 5
//Expected Output:
//5 * 0 = 0
//5 * 1 = 5
//5 * 2 = 10
//5 * 3 = 15
//....
//5 * 10 = 50

Console.WriteLine("Part 5:");
i = 0;
Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
while (i <= 10)
{
    Console.WriteLine(number + " * " + i + " = " + number * i);
    i++;
}



//Part 6
//Write a C# Sharp program that takes a number as input and print its factorial.
//Hint: You can use a while loop to calculate the factorial of a number.
//Test Data:
//Enter the number: 5
//Expected Output:
//The factorial of 5 is: 120

Console.WriteLine("Part 6:");
i = 1;
int factorial = 1;
Console.WriteLine("Enter the number: ");
number = Convert.ToInt32(Console.ReadLine());
while (i <= number)
{
    factorial *= i;
    i++;
}

Console.WriteLine("The factorial of " + number + " is: " + factorial);





//Part 7
//Write a C# Sharp program that takes a number as input and print the series 1+2+3+ ... +n = sum
//Hint: You can use a while loop to calculate the sum of a series.
//Test Data:
//Enter the number: 5
//Expected Output:
//1 + 2 + 3 + 4 + 5 = 15

Console.WriteLine("Part 7:");
Console.WriteLine("Enter the number: ");
string output = "";
number = Convert.ToInt32(Console.ReadLine());
i = 1;
int sum = 0;
while (i <= number)
{
    output += i <= number ? i + " + " : i.ToString();
    sum += i;
    i++;
}
Console.WriteLine(output + " = " + sum);









//Part 8
//Write a program in C# Sharp to display the multiplication table horizontally from 1 to n.
//Hint: You can use conseol.write to print out the multiplication table horizontally.
//Test Data:
//Input upto the table number starting from 1 : 8
//Expected Output:
//Multiplication table from 1 to 8
//1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
//...
//1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80

Console.WriteLine("Part 8:");
Console.WriteLine("Input upto the table number starting from 1 : ");
int tableNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Multiplication table from 1 to " + tableNumber);
i = 1;
while (i <= tableNumber)
{
    int j = 1;
    while (j <= 10)
    {
        Console.Write(i + "x" + j + " = " + i * j + ", ");
        j++;
    }
    Console.WriteLine();
    i++;
}



//Part 9
//Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
//Hint: You can use a while loop to print out the pattern.
//Test Data:
//Input number of rows : 3
//Expected Output:
//1
//12
//123

Console.WriteLine("Part 9:");
Console.WriteLine("Input number of rows : ");
int rows = Convert.ToInt32(Console.ReadLine());
i = 1;
while (i <= rows)
{
    int j = 1;
    while (j <= i)
    {
        Console.Write(j);
        j++;
    }
    Console.WriteLine();
    i++;
}









//Part 10
//Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
//Hint: You can use a while loop to print out the pattern.
//Test Data:
//Input number of rows : 3
//Expected Output:
//*
//**
//***

Console.WriteLine("Part 10:");
Console.WriteLine("Input number of rows : ");
rows = Convert.ToInt32(Console.ReadLine());
i = 1;
while (i <= rows)
{
    int j = 1;
    while (j <= i)
    {
        Console.Write("*");
        j++;
    }
    Console.WriteLine();
    i++;
}






//Part 11
//Write a program in C# Sharp to make such a pattern like a pyramid with numbers increasing by 1.
//Hint: You can use a while loop to print out the pattern.
//Test Data:
//Input number of rows : 5
//Expected Output:
//    1
//   2 3
//  4 5 6
// 7 8 9 10
//11 12 13 14 15


Console.WriteLine("Part 11:");
Console.WriteLine("Input number of rows : ");
rows = Convert.ToInt32(Console.ReadLine());
number = 1;
i = 1;
while (i <= rows)
{
    int j = 1;
    while (j <= rows - i)
    {
        Console.Write(" ");
        j++;
    }
    j = 1;
    while (j <= i)
    {
        Console.Write(number + " ");
        number++;
        j++;
    }
    Console.WriteLine();
    i++;
}



////////////////Do While Loop////////////////


//while loop: Condition is checked before the loop body runs.

//do-while loop: Loop body runs at least once before checking the condition.

//Example(Uncomment each loop type to see the difference) 


//While Loop//

int x = 1;
while (x < 1)
{
    Console.WriteLine(x);
    x++;
}



//Do While Loop//

x = 1;
do
{
    Console.WriteLine(x);
    x++;
} while (x < 1);



