// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please Enter Student's Grade: ");
// Global variable / Global scope
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
else if(grade >=85 && grade <= 100) 
{
    Console.WriteLine("A - Good Job");
}
int gradeAfterBonus = grade >= 0 && grade <= 100 ? grade +10 : 0;
Console.WriteLine("********************* Complex IF.. ELSE.. IF Results End *********************");

Console.WriteLine("Thank you for using this program.");

/* Ternary Operator used to assign a value to a variable based on a condition */
Console.WriteLine("********************* Ternary Operator Result *********************");

string passStatus = grade < 50 ? "Fail" : "PASS";
Console.WriteLine($"Student Status is {passStatus}");

Console.WriteLine("********************* Ternary Operator Result End *********************");


/* Write a program to accept an integer as the day of the week and print the appropriate message as outlined below.
 * 1. Sunday
 * 2. Monday
 * 3. Tuesday
 * 4. Wednesday (Hump Day!)
 * 5. Thursday
 * 6. Friday (TGIF!!!)
 * 7. Saturday (Beach Day!!!)
 */
Console.WriteLine("Please Enter A number for a Day of the week: ");

int dayOfWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
}

Console.WriteLine("********************* Switch Operator Result End *********************");
