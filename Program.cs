


void rest()
{
    Console.WriteLine("введите  число a");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a % 2 == 0) Console.WriteLine("число четное");
    else if (a % 2 != 0) Console.WriteLine("число нечетное");


}
rest();










void res()
{
    Console.WriteLine("введите  число a");
    int a = Convert.ToInt32(Console.ReadLine());


    for (int i = 2; i < a; i++)
    {
        if (i % 2 == 0)
            Console.Write(i);
    }
}
res();


---------
int SummaFor(int N)
            {
    int sum = 0;
    for (int i = 1; i <= N; i++) sum += i;
    return sum;
}
int SummaWhile(int N)
{
    int sum = 0;
    int i = 1;
    while (i <= N)
    {
        sum += i;
        i++;
    }
    return sum;
}

try
{
    Console.Write("Введите целое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма всех натуральных чисел от 1 до {a} через цикл FOR равна {SummaFor(a)}");
    Console.WriteLine($"Сумма всех натуральных чисел от 1 до {a} через цикл WHILE равна {SummaWhile(a)}");

}
catch (System.Exception)
{

    Console.WriteLine("Надо было вводить именно целое число!");
}


-----
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
