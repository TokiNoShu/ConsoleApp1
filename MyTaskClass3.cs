using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass3
{
    private double _n;
    private double _y;

    public MyTaskClass3(double n, double y)
    {
        _n = n;
        _y = y;
    }

    public void G()
    {
        Console.WriteLine($"G = {_n * (_y + 3.5) + Math.Sqrt(_y)}");
    }
}
