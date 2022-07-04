static int AckermannFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckermannFunc(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    }
    else
        return n + 1;
}
Console.WriteLine(AckermannFunc(3,2));
Console.WriteLine(AckermannFunc(2,3));
Console.WriteLine(AckermannFunc(0,3));
Console.WriteLine(AckermannFunc(4,0));