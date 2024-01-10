string[] words = { "Hello", "2", "world", ":-@"};
  
IEnumerable <string> query = from word in words  
                             where word.Length < 4  
                             select word;  
  
foreach (string str in query)  
Console.WriteLine(str);  