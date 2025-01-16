using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass10
{
    private double _e;
    private double _y;
    private double _k;
    private double _x;

    public MyTaskClass10(double e, double y, double k, double x)
    {  
        _y = y;
        _e = e;
        _k = k;
        _x = x;
    }

    public void U()
    {
        Console.WriteLine($"U = {Math.Pow(_e, _y) + 7.355 * Math.Pow(_k, 2) + Math.Pow(Math.Sin(_x), 2)}");
    }
}
