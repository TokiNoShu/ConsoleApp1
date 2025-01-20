using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass19
{
    private double _y;
    private double _g;
    private double _n;

    public MyTaskClass19(double y, double g, double n)
    {  
        _y = y;
        _g = g;
        _n = n;
    }

    public void P()
    {
        Console.WriteLine($"P = {_n * Math.Sqrt(Math.Pow(_y, 3) + 1.09 * _g)}");
    }
}
