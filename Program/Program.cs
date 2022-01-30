var names = new string[] { "ABOBA", ":D", ">:X", "computer", "Ru", "ASHD" };
// находим элементы, у которых длина строки меньше или равна 3
string[] array = Array.FindAll(names, name => name.Length <= 3);
foreach (var name in array) 
Console.WriteLine(name);

