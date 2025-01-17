using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass20
{
    private double _y;
    private double _x;
    private double _k;
    private double _e;

    public MyTaskClass20(double y, double e, double k, double x)
    {  
        _y = y;
        _e = e;
        _k = k;
        _x = x;

    }

    public void U()
    {
        Console.WriteLine($"U = {Math.Pow(_e, _k + _y) + Math.Tan(_x * Math.Sqrt(_y))}");
    }
}
