// ---------------------------------------------------------------------
// Question: Finding the First Element Meeting a Condition in an Array
// Write a C# program to find and display the first element greater than 50 in an integer array.
// Hint: Use the Array.Find() method with a condition-checking function (Predicate) to find the first element greater than 50 in the array.
// Define a condition-checking function that returns true if the element is greater than 50.

int[] array = { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
int firstElementGreaterThan50 = Array.Find(array, element => element > 50);
Console.WriteLine("The first element greater than 50 is: " + firstElementGreaterThan50);

// ---------------------------------------------------------------------
// Question: Find the First Element Greater Than 10
// Write a C# program that finds the first element greater than 10 in an integer array and displays it.
// Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first element greater than 10.
// Define a condition-checking function that returns true if the element is greater than 10.

int firstElementGreaterThan10 = Array.Find(array, element => element > 10);
Console.WriteLine("The first element greater than 10 is: " + firstElementGreaterThan10);

// ---------------------------------------------------------------------

//---------------------------------------------------------------------
// Question: Find the First Negative Number
// Write a C# program to find the first negative number in an array of integers and display it.
// Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first negative number.
// Define a condition-checking function that returns true if the element is negative.

array = new int[] { 10, -15, 20, -25, 30, -35, 40, -45, 50, -55, 60, -65, 70, -75, 80, -85, 90, -95, 100 }
;

int firstNegativeNumber = Array.Find(array, element => element < 0);
Console.WriteLine("The first negative number is: " + firstNegativeNumber);