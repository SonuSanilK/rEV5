Console.WriteLine("Enter the name");
string name = Console.ReadLine();
string rev = string.Empty;
for (int i = name.Length - 1; i >= 0; i--)
{
    rev += name[i];
}
Console.WriteLine($"Reverse is {rev}");//commit
// This is for sample.kh