var math = new Math();
math.PI = 3.14;
math.E = 2.71;

System.Console.WriteLine(math.Min(10,2));

class Math()
{
    public double PI;
    public double E;
    public double Abs(double a)
    {
        if(a < 0) {return a*(-1);}
        else {return a;}
    }
    public float Abs(float a)
    {
        if(a < 0) {return a*(-1);}
        else {return a;}
    }
    public int Abs(int a)
    {
        if(a < 0) {return a*(-1);}
        else {return a;}
    }
    public double Pow(double x, double y)
    {
        double cnt=1;
        for (int i = 1; i <= y; i++)
        {
            cnt*=x;
        }
        return cnt;
    }
    public double Sqrt(double a)
    {
        double cnt=0;
        cnt=System.Math.Sqrt(a);
        return cnt;
    }
    public int Max(int a, int b)
    {
        if(a >= b) {return a;}
        else {return b;}
    }
    public int Min(int a, int b)
    {
        if(a <= b) {return a;}
        else {return b;}
    }
}