try
{
    // Simulating some code that might throw an exception
    Console.WriteLine("Starting the application...");
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered age: {age}");
}
catch (Exception ex)
{
    Console.WriteLine($"Caught a general exception: {ex.Message}");
}
finally
{
    Console.WriteLine("Thank you...");
}
