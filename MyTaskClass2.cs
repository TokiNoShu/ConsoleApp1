using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass2
{
    private double _p;
    private double _y;
    private double _e;

    public MyTaskClass2(double p, double y, double e)
    {
        _p = p;
        _y = y;
        _e = e;
    }

    public void K()
    {
        Console.WriteLine($"K = {Math.Log(Math.Pow(_p, 2) + Math.Pow(_y, 3) + Math.Pow(_e, _p))}");
    }
}
