
/*
 * For Loop Example
*/


//print X times "Hello, World!" based on the user input 

Console.WriteLine("Welcome to the Hello World For Loop Console Application!");
Console.Write("Enter the number of times to print 'Hello, World!': ");
int timesToPrint = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < timesToPrint; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

/* 
 * While Loop Example
*/

//print X times "Hello, World!" based on the user input using a while loop
Console.WriteLine("Welcome to the Hello World While Loop Console Application!");
Console.Write("Enter the number of times to print 'Hello, World!': ");
int timesToPrintWhile = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count < timesToPrintWhile)
{
    Console.WriteLine($"Hello, World! - {count}");
    count++;
}

/*
 * Do While Loop Example
*/
//print X times "Hello, World!" based on the user input using a do while loop
Console.WriteLine("Welcome to the Hello World Do While Loop Console Application!");
Console.Write("Enter the number of times to print 'Hello, World!': ");
int timesToPrintDoWhile = Convert.ToInt32(Console.ReadLine());
int countDoWhile = 0;
do
{
    Console.WriteLine($"Hello, World! - {countDoWhile}");
    countDoWhile++;
} while (countDoWhile < timesToPrintDoWhile);