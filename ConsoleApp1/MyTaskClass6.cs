using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass6
{
    private double _y;
    private double _x;
    private double _e;

    public MyTaskClass6(double y, double e, double x)
    {
        _y = y;
        _e  = e;
        _x = x;
    }

    public void M()
    {
        Console.WriteLine($"M = {Math.Cos(2) * _y + 3.6 * Math.Pow(_e, _x)}");
    }

}
