using System;
class Program { static void Main(){ int[,] A={{1,2},{3,4}}, B={{5,6},{7,8}}, C=new int[2,2];
 for(int i=0;i<2;i++) for(int j=0;j<2;j++){ C[i,j]=0; for(int k=0;k<2;k++) C[i,j]+=A[i,k]*B[k,j]; }
 Console.WriteLine($"[{C[0,0]} {C[0,1]}]\n[{C[1,0]} {C[1,1]}]"); } }