using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass5
{
    private double _x;

    public MyTaskClass5(double x)
    {
        _x = x;
    }

    public void L()
    {
        Console.WriteLine($"L = {1.51 * Math.Cos(Math.Pow(_x, 2)) + 2 * Math.Pow(_x, 3)}");
    }
}
