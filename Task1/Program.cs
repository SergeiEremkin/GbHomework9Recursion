//Задача 66
int SumElements(int M, int N)
{
    if (M<N)
    {
         M += SumElements(M+1, N);
    }
    return M;
}
System.Console.WriteLine(SumElements(1,10));
System.Console.WriteLine(SumElements(1,2));
System.Console.WriteLine(SumElements(5,7));
