
Console.WriteLine("Hello, World!");
Console.Write("Число а: ");
 int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Число b: ");
 int b = Convert.ToInt32(Console.ReadLine());

 int i = a;
 for (i = a; i <= b; i++)
{
    if (i % 2 == 0)
    Console.Write(i+ " ");
}