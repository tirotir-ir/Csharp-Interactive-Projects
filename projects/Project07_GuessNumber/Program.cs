using System;
class Program { static void Main(){ var rnd=new Random(); int secret=rnd.Next(1,101); int tries=0;
 Console.WriteLine("Guess (1..100)"); while(true){ tries++; Console.Write("> ");
 if(!int.TryParse(Console.ReadLine(), out int g)) continue; if(g==secret){ Console.WriteLine($"Win in {tries} tries!"); break;}
 Console.WriteLine(g<secret? "Higher":"Lower"); } } }