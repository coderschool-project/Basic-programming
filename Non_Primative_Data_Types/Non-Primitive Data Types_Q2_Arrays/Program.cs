﻿
//**Arrays unlike lists have a fixed size and cannot be changed once they are created.**//


//---------------------------------------------------------------------
// Part 1: Printing Array Elements
// Create an array of 5 countries and then print them out to the console.
// Hint: Use a foreach loop to print the array elements.

string[] names = { "United States", "Canada", "Mexico", "Brazil", "Argentina" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

//---------------------------------------------------------------------
// Part 2: Accessing Array Elements by Index
// Using the array of countries, find the name in the 3rd position and print it out to the console.
// Hint: Use the index of the array to access the name in the 3rd position.
Console.WriteLine(names[2]);

//---------------------------------------------------------------------
// Part 3: Removing an Element from the Array
// Using the array of countries, remove the name in the 2nd position and then print the array out to the console.
// Hint: Use the RemoveAt() method to remove an item from the array.

names.RemoveAt(1);
Console.WriteLine(names[1]);

//---------------------------------------------------------------------
// Part 4: Replacing an Element in the Array
// Using the array of countries, replace the name in the 3rd position with a new name and then print the array out to the console.
// Hint: Use the index of the array to replace the name in the 3rd position with a new name.

names[2] = "Chile";

//---------------------------------------------------------------------
// Part 5: Finding the Length of the Array
// Using the array of countries, find the length of the array and print it out to the console.
// Hint: Use the Length property to find the length of the array.

Console.WriteLine(names.Length);

//---------------------------------------------------------------------
// Part 6: Checking if an Element Exists in the Array
// Using the array of countries, check if a name exists in the array and print out if it exists or not.
// Hint: Use the Contains() method to check if a name exists in the array.

if (names.Contains("Brazil"))
{
    Console.WriteLine("Brazil exists in the array.");
}
else
{
    Console.WriteLine("Brazil does not exist in the array.");
}

//---------------------------------------------------------------------
// Part 7: Finding the Index of an Element in the Array
// Using the array of countries, find the index of a name in the array and print it out to the console.
// Hint: Use the IndexOf() method to find the index of a name in the array.

Console.WriteLine(Array.IndexOf(names, "Chile"));


