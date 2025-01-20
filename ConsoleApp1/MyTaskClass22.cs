using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass22
{
    private double _y;
    private double _x;
    private double _u;

    public MyTaskClass22(double y, double u, double x)
    {  
        _y = y;
        _u = u;
        _x = x;
    }

    public void T()
    {
        Console.WriteLine($"T = {Math.Sin(2 * _u) * Math.Log(2 * Math.Pow(_y, 2) + Math.Sqrt(_x))}");
    }
}
