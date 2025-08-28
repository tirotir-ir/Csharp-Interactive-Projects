using System;
class Program { static void Main(){ Console.Write("terms? ");
 if(!int.TryParse(Console.ReadLine(), out int n)) return;
 long a=0,b=1; Console.Write(a+" "+b+" "); for(int i=2;i<n;i++){ long c=a+b; Console.Write(c+" "); a=b; b=c; } } }