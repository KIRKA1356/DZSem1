Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int n2 = n1 % 2;

if (n2 >0)
{
    Console.WriteLine("Число нечетное");
}
    else
        {
            Console.WriteLine("Число четное");
        }
