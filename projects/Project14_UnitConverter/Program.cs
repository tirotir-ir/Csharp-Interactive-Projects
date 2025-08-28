using System;
class Program { static void Main(){ Console.WriteLine("1)m->ft 2)kg->lb"); Console.Write("choice: ");
 var c=Console.ReadLine(); if(c=="1"){ Console.Write("m: "); double m=double.Parse(Console.ReadLine()!); Console.WriteLine(m*3.28084+" ft"); }
 else { Console.Write("kg: "); double kg=double.Parse(Console.ReadLine()!); Console.WriteLine(kg*2.20462+" lb"); } } }