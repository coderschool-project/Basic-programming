//Part 1 Print a string to the console
//hint: Console.WriteLine("Hello World!");
Console.WriteLine("Part 1:");
Console.WriteLine("Hello World!");
//Part 2 Get user input and print it to the console
//hint: Console.ReadLine();
Console.WriteLine("Part 2:");
string input;
input = Console.ReadLine() ?? string.Empty;
Console.WriteLine(input);
//Part 3 Get two inputs from the user and print them on separate lines
//hint: use \n to create a new line
Console.WriteLine("Part 3:");
string input1;
string input2;
input1 = Console.ReadLine() ?? string.Empty;
input2 = Console.ReadLine() ?? string.Empty;
Console.WriteLine(input1 + "\n" + input2);



