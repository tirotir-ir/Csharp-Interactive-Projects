using System; using System.Text.Json; using System.Collections.Generic;
class Program { record Person(string Name, int Age);
static void Main(){ var people = new List<Person>{ new("Ali",20), new("Sara",22)};
 var json = JsonSerializer.Serialize(people, new JsonSerializerOptions{WriteIndented=true}); Console.WriteLine(json);
 var back = JsonSerializer.Deserialize<List<Person>>(json); Console.WriteLine("Count: "+back!.Count); } }