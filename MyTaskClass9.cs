using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass9
{
    private double _y;
    private double _x;

    public MyTaskClass9(double y, double x)
    {  
        _y = y;
        _x = x;
    }

    public void V()
    {
        Console.WriteLine($"V = {Math.Log(_y + 0.95) + Math.Sin(Math.Pow(_x, 4))}");
    }
}
