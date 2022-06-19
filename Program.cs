int max;
Console.WriteLine("ВВедите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1>n2 && n1>n3)
{
    max=n1;
}
    else
        {
            max=n2;
        }
            if (n2<n3 && n3>n1)
            {
                max=n3;
            }
Console.WriteLine("Максимальное число: " + max);