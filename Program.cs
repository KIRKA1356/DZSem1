Console.WriteLine("ВВедите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1>n2)
{
    Console.WriteLine("Большее число " + n1);
    Console.WriteLine("Меньшее число " + n2);
}
    else
        if (n1<n2)
        {
            Console.WriteLine("Большее число " + n2);
            Console.WriteLine("Меньшее число " + n1);
        }
            else
            {
                Console.WriteLine("Числа равны");
            }