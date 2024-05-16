// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please Enter Student's Grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Simple If... Else... Statement - Decide to print pass or fail based on input
Console.WriteLine("********************* Simple If Results *********************");

Console.Write("Please Enter Student's Grade: ");
if (grade > 50)
{
    Console.WriteLine("Student has Passed.");
} 
else
{
    Console.WriteLine("Student has Failed.");
    Console.WriteLine("Please recommend student to student affairs office.");
}
Console.WriteLine("********************* Simple If Results End *********************");

// Complex If... Else... Statement - Decide to print pass or fail based on input
Console.WriteLine("********************* Complex IF.. ELSE.. IF Results *********************");

/* A: 86-100
 * B: 75-84
 * C: 65-74
 * D: 50-64
 * F: Less than 50
 */
if(grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid Value Entered.");
}
else if (grade < 50)
{
    Console.WriteLine("Student has Failed - F");
}
else if (grade >= 50 && grade <= 64)
{
    Console.WriteLine("D");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else 
{
    Console.WriteLine("A - Good Job");
}
Console.WriteLine("********************* Complex IF.. ELSE.. IF Results End *********************");

Console.WriteLine("Thank you for using this program.");

/* Ternary Operator used to assign a value to a variable based on a condition */
Console.WriteLine("********************* Ternary Operator Result *********************");

string passStatus = grade < 50 ? "Fail" : "PASS";
Console.WriteLine($"Student Status is {passStatus}");

Console.WriteLine("********************* Ternary Operator Result End *********************");