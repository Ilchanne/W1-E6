double c = 0;
Console.WriteLine("Введите первый множитель:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второй множитель:");
double b = Convert.ToDouble(Console.ReadLine());
c = a;
for(int i = 1; i < b; i++)
{
    c = c + a;
}
Console.WriteLine($"{a}*{b}={c}");