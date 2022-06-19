Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int n2 = 2;
int count=0;

while (count < n1)
{
    if (n2<=n1)
    {
    Console.Write(" " + n2);
    }
    n2=n2+2;
    count= count +2;
}
