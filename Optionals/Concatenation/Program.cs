// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.




//Part 1
//Write a C# program that concatenates two strings (player's first and last name) and then outputs the result.
//Hint: You can assign a string to a variable using the = operator.
//Hint: You can use the + operator to concatenate two strings.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Part 1:");
string concatenateStringsPart1(string firstName, string lastName)
{
    return firstName + " " + lastName;
}
Console.WriteLine(concatenateStringsPart1("John", "Doe"));



//Part 2
//Modify the program so that it gets the two strings from the user(for username).
//Hint: You can use the Console.ReadLine() method to get a string from the user.
//Hint: You can use the Console.WriteLine() method to prompt the user for input.
//Hint: You can use the Console.WriteLine() method to output the result.

Console.WriteLine("Part 2:");
string concatenateStringsPart2()
{
    string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    return firstName + " " + lastName;
}
Console.WriteLine(concatenateStringsPart2());


//Part 3
//Modify the program so that it concatenates three strings instead of two (clan name).
//Hint: You can use the + operator to concatenate three strings.
//Hint: You can use the Console.WriteLine() method to output the result.

Console.WriteLine("Part 3:");
string concatenateStringsPart3(string clanName, string firstName, string lastName)
{
    return clanName + " " + firstName + " " + lastName;
}
Console.WriteLine(concatenateStringsPart3("Red", "John", "Doe"));


//Part 4
//Modify the program to concatenate a string and an integer(incase,player name had numebrs).
//Hint: You can use the + operator to concatenate a string and an integer.
//Hint: You can use the Console.ReadLine() method to get an integer from the user.
//Hint: You can use the int.Parse() method to convert a string to an integer.
//Hint: You can use the Console.WriteLine() method to output the result.

Console.WriteLine("Part 4:");
string concatenateStringsPart4()
{
    string firstName = Console.ReadLine();
    int number = Convert.ToInt32(Console.ReadLine());
    return firstName + " " + number;
}

Console.WriteLine(concatenateStringsPart4());




