using System.Diagnostics.CodeAnalysis;
//
Console.Write("Ведите на сколько пролдолжить: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Ведите чему = x: ");
int x = int.Parse(Console.ReadLine());


double sum=0;
//double c = Math.Cos(n * x) / n;

for (int i=1;i<=n;i++)
{
    sum+=Math.Cos(i * x) / i; 
 

}
Console.WriteLine(sum);



//double v= Math.Cos(n*x)/n
