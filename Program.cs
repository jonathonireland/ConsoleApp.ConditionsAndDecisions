// See https://aka.ms/new-console-template for more information
Console.Write("Please Enter Student's Grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

if(grade > 50)
{
    Console.WriteLine("Student has Passed.");
} 
else
{
    Console.WriteLine("Student has Failed.");
    Console.WriteLine("Please recommend student to student affairs office.");
}
Console.WriteLine("Thank you for using this program.");