//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b)
//     Console.Write(a + " > " + b);
// else
//     Console.Write(b + " > " + a);



//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = 0;

// if (a > b)
//     max = a;
// else
//     max = b;
// if (c > b)
//     max = c;
// else
//     max = b;
// if (a > c)
//     max = a;
// else
//     max = c;
// Console.Write("max_number = " + max);


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
// Console.Write("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0)
//     Console.Write(a + " -> yes");
// else
//      Console.Write(a + " -> no");


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    if (i % 2 ==0)

        Console.Write(i +",");
 
}    