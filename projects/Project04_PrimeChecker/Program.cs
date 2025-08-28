using System;
class Program { static bool IsPrime(int n){
    if (n<2) return false; if (n%2==0) return n==2;
    for(int i=3;i*i<=n;i+=2) if(n%i==0) return false; return true;}
static void Main(){ Console.Write("n? "); if(!int.TryParse(Console.ReadLine(), out int n)) return;
    Console.WriteLine(IsPrime(n)? "Prime":"Not prime"); }}