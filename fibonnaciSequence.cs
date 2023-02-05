//Declaration of variables
int n;
int x = 1, y = 0, z = 0;
//Input
Console.Write("Write a number for fibonacci sequence: ");
n = int.Parse(Console.ReadLine());  
//Processing
for (int i = 0;i < n; i++)
{
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}