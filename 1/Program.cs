
void Filtration(string[] arr)
{
System.Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length < 4)
    {
    System.Console.Write($"{arr[i] }");
    }
}
System.Console.Write("]");
}


string[] arr = { "Russia", "Denmark", "Kazan", "Ufa"};
Filtration(arr);



