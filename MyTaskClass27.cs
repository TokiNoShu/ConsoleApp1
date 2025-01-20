using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass27
{
    private double _y;
    private double _x;
    private double _v;
    private double _e;

    public MyTaskClass27(double y, double x, double v, double e)
    {  
        _y = y;
        _x = x;
        _v = v;
        _e = e;

    }

    public void W()
    {
        Console.WriteLine($"W = {1.03 * _v + Math.Pow(_e, 2 * _y) + Math.Tan(Math.Abs(_x))}");
    }
}
