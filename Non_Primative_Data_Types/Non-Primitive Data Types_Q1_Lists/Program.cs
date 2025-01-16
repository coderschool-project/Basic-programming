using System;
//Part 1
//Create a list of 5 names and then print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.
List<string> names = new List<string>();
names.Add("John");
names.Add("Jane");
names.Add("Bob");
names.Add("Alice");
names.Add("Dave");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Part 2
//Using the list of names and find the name in the 3rd position and print it out to the console.
//Hint: You can use the index of the list to find the name in the 3rd position.

Console.WriteLine(names[2]);

//Part 3
//Using the list of names, remove the name in the 2nd position and then print the list out to the console.
//Hint: You can use the RemoveAt() method to remove an item from the list.
names.RemoveAt(1);
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Part 4
//Using the list of names, add a new name to the list and then print the list out to the console.
//Hint: You can use the Add() method to add a new name to the list

names.Add("Charlie");
foreach (string name in names)
{
    Console.WriteLine(name);
}


//Part 5
//Using the list of names , find the length of the list and print it out to the console.
//Hint: You can use the Count property to find the length of the list.

Console.WriteLine(names.Count);

//Part 6
//Using the list of names , check if a name exists in the list and print out if it exists or not.
//Hint: You can use the Contains() method to check if a name exists in the list.

if (names.Contains("Alice"))
{
    Console.WriteLine("Alice exists in the list.");
}
else
{
    Console.WriteLine("Alice does not exist in the list.");
}

//Part 7
//Using the list of names, find the index of a name in the list and print it out to the console.
//Hint: You can use the IndexOf() method to find the index of a name in the list.

Console.WriteLine(names.IndexOf("Charlie"));

//Part 8
//Using the list of names, insert a new name at the 3rd position and print the list out to the console.
//Hint: You can use the Insert() method to insert a new name at a specific position in the list.

names.Insert(2, "Eve");

//Part 9
//Using the list of names, sort the list and print it out to the console.
//Hint: You can use the Sort() method to sort the list.

names.Sort();


//Part 10
//Using the list of names , use findlastindex() method to find the last index of a name in the list and print it out to the console.
//Hint: You can use the FindLastIndex() method to find the last index of a name in the list.

Console.WriteLine(names.FindLastIndex(name => name == "Eve"));

//Part 11
//Using the list of names, clear the list and print the list out to the console.
//Hint: You can use the Clear() method to clear the list.

names.Clear();


//Part 12
//Create a new list of strings and integers and print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.

List<object> mixedList = new List<object>();
mixedList.Add("John");
mixedList.Add(25);
mixedList.Add("Jane");
mixedList.Add(30);
foreach (object item in mixedList)
{
    Console.WriteLine(item);
}




