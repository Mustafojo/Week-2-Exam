namespace math;

public class Math
{
    const double PI = 3.14;
    const double E = 2.71;
    
    public double Abs(double value)
    {
        if (value < 0)
        {
            return value = value * (-1);
        }
        else
        {
            return value;
        }
    }
    public float Abs(float value)
    {
        if (value < 0)
        {
            return value = value * (-1);
        }
        else
        {
            return value;
        }
    }

    public int Abs(int value)
    {
        if (value < 0)
        {
            return value = value * (-1);
        }
        else
        {
            return value;
        }
    }
    public double Pow(double x, double y)
    {
        double sum = 1;
        for (int i = 0; i < y; i++)
        {
            sum *= x;
        }
        return sum;
    }
    public double Sqrt(double d)
    {
        return System.Math.Sqrt(d);
    }
    public int Max(int val1, int val2)
    {
        if(val1 > val2)
        {
            return val1;
        }
        else
        {
            return val2;
        }
    }
     public int Min(int val1, int val2)
    {
        if(val1 > val2)
        {
            return val2;
        }
        else
        {
            return val1;
        }
    }

}
