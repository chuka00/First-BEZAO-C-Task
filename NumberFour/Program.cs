Console.WriteLine("'Break' Example");

int j = 0;
while (j < 10)
{
    Console.WriteLine(j);
    j++;
    if (j == 4)
    {
        break;
    }
}
Console.WriteLine(j);



Console.WriteLine("'Continue' Example");
int i = 0;
while (i < 10)
{
    if (i == 4)
    {
        i++;
        continue;
    }
    Console.WriteLine(i);
    i++;
}
Console.WriteLine(i);