using System; using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var list = new List<string>(); string cmd;
        Console.WriteLine("Commands: add <text>, del <index>, list, exit");
        while (true)
        {
            Console.Write("todo> "); cmd = Console.ReadLine() ?? ""; var parts = cmd.Split(' ', 2);
            switch (parts[0])
            {
                case "add": list.Add(parts.Length > 1 ? parts[1] : "(empty)"); break;
                case "del": if (parts.Length > 1 && int.TryParse(parts[1], out int i) && i >= 0 && i < list.Count) list.RemoveAt(i); break;
                case "list": for (int k = 0; k < list.Count; k++) Console.WriteLine($"[{k}] {list[k]}"); break;
                case "exit": return;
            }
        }
    }
}