// See https://aka.ms/new-console-template for more information

// Datatypes and Variables
/*
  Text: string
  Integer: int
  Decimal: decimal, double, float
  Boolean: bool
*/

string name = "Muthu";

Console.WriteLine("Hello, " + name + "!");      // Concatenation using + operator

Console.WriteLine($"Hello, {name}!");         // String interpolation using $ and {}    

Console.WriteLine("Hello, {0}!", name);      // String formatting using placeholders

int age = 35;

int retirementYearsLeft = 23;

int retirementAge = age + retirementYearsLeft;

Console.WriteLine("I am {0} years old.", age); // String formatting with placeholders

Console.WriteLine($"I will retire at {retirementAge} years old."); // String interpolation

bool isRetired = false;

Console.WriteLine($"Am I retired? {isRetired}"); // String interpolation with boolean