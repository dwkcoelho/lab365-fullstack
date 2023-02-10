
List<string> studentName = new List<string>();
List<float> studentNote = new List<float>();

for (int i = 0; i < 5; i++)
{
    Console.Write("Write the name of " + (i + 1) + "° student: ");
    studentName.Add(Console.ReadLine());
    Console.Write("Write the student average: ");
    studentNote.Add(float.Parse(Console.ReadLine()));
}

for (int i = 0; i < 5; i++)
{
    if (studentNote[i] < 6)
    {
        Console.WriteLine(studentName[i] + " student failed.");
    }
    else
    {
        Console.WriteLine(studentName[i] + " student was approved.");
    }
}