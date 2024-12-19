using System;
using System.Diagnostics.CodeAnalysis;

//task1
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Number ;" + i);

}
//task2
int total = 0;
for (int i = 1; i <= 5; i++)
{

    total += i;

}
Console.WriteLine("Number ;" + total);
Console.WriteLine("enter loop number");


//task3

//loop num 10 readline 
//x
//condtion i<=x 

Console.WriteLine("enter loop number");

int loopnumber=Convert.ToInt32(Console.ReadLine());
int totall = 0;
for (int i = 1; i <= loopnumber; i++)
{
    Console.WriteLine($"Enter Number {i} to be added" );
    total=Convert.ToInt32(Console.ReadLine());
  

}
Console.WriteLine(" The Total is ;  " + totall);


// task 4 
int number;
Console.WriteLine("enter number");
number =Convert.ToInt32(Console.ReadLine());
while (number < 0) {
    Console.WriteLine("invailid input. plase enter a positive number .");
    Console.WriteLine("enter a positive number ; ");
    number=Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"you entered a valid number :{number}");





