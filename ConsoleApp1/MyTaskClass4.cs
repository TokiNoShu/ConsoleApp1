using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass4
{
    private double _a;
    private double _t;

    public MyTaskClass4(double a, double t)
    {
        _a = a;
        _t = t;
    }

    public void D()
    {
        Console.WriteLine($"D = {9.8 * Math.Pow(_a, 2) + 5.52 * Math.Cos(Math.Pow(_t, 5))}");
    }
}
