using System;
class Program { static void Main(){ Console.Write("Weight(kg): "); double w=double.Parse(Console.ReadLine()!);
 Console.Write("Height(m): "); double h=double.Parse(Console.ReadLine()!); double bmi=w/(h*h);
 string cat = bmi<18.5?"Under" : bmi<25?"Normal" : bmi<30?"Over" : "Obese";
 Console.WriteLine($"BMI={bmi:F1} => {cat}"); } }