// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] studentsG1 = new string[5] { "Krste","Petko","Trajko","Milan","Stojan"};
string[] studentsG2 = new string[5] { "Zdravko", "Darko", "Stanko", "Branko", "Andrej" };

Console.WriteLine("Enter student group: (1 or 2): ");
int groupNumber = 0;

if (!int.TryParse(Console.ReadLine(), out groupNumber))
{
    Console.WriteLine("Please enter valid number");
}
else if(groupNumber == 1)
{
    Console.WriteLine("The students from G1 are : ");
    foreach(string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}else if(groupNumber == 2)
{
    Console.WriteLine("The students from G2 are: ");
    foreach(string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
