double CalculateFormule(int a, int b, int c, int d)
{
    double num = a * b;
    int denum = c + d;
    double res = num / denum; 
    return res;
}

double result = CalculateFormule(1, 2, 3, 4);
Console.WriteLine(result);