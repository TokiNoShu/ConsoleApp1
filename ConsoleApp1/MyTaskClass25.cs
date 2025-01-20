using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass25
{
    private double _y;
    private double _e;
    private double _f;

    public MyTaskClass25(double y, double e, double f)
    {  
        _y = y;
        _e = e;
        _f = f;

    }

    public void G()
    {
        Console.WriteLine($"G = {Math.Pow(_e, 2 * _y) + Math.Sin(Math.Pow(_f, 2))}");
    }
}
