// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbersArr = new int[6];


for (int i = 0; i < numbersArr.Length; i++)
{
    Console.WriteLine("Enter 6 numbers: ");

    if (!int.TryParse(Console.ReadLine(), out numbersArr[i])){
        Console.WriteLine("Enter a Valid Number! ");
    }


    int sum = 0;
    foreach(int number in numbersArr)
    {
        if (number%2==0) { 
        sum += number;
        }
    }
    Console.WriteLine("The result is:" + sum);
}