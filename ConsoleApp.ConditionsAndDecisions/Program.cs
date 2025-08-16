Console.Write("Enter Student's grade (integer): ");
int grade = Convert.ToInt32(Console.ReadLine());

//Decision making using simple if-else statements
if (grade <= 100 && grade >= 35)
{
    Console.WriteLine("You have passed the exam.");
}
else
{
    Console.WriteLine("You have failed the exam.");
}

//Decision making using complex if-else statements
if ( grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid grade value");
}
else if (grade >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (grade >= 80)
{
    Console.WriteLine("Grade: B");
}
else if (grade >= 70)
{
    Console.WriteLine("Grade: C");
}
else if (grade < 70 && grade >= 35)
{
    Console.WriteLine("Grade: D");
}
else
{
    Console.WriteLine("Grade: F");
}

/*
 * Ternary operator for grading
*/

string result = (grade >= 35 && grade <= 100) ? "Pass" : "Fail";
Console.WriteLine($"Result using ternary operator: {result}");

//Switch statement for grading
Console.WriteLine("Switch Case Results");
switch (grade)
{
    case >= 90:
        Console.WriteLine("Grade: A");
        break;
    case >= 80:
        Console.WriteLine("Grade: B");
        break;
    case >= 70:
        Console.WriteLine("Grade: C");
        break;
    case >= 35:
        Console.WriteLine("Grade: D");
        break;
    default:
        Console.WriteLine("Grade: F");
        break;
}

Console.WriteLine("Thank you for using the grading system!");



