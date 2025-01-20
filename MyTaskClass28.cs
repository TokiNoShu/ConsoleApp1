using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass28
{
    private double _y;
    private double _e;
    private double _h;

    public MyTaskClass28(double y, double e, double h)
    {  
        _y = y;
        _e = e;
        _h = h;
    }

    public void T()
    {
        Console.WriteLine($"T = {Math.Pow(_e, _y + _h) + Math.Sqrt(Math.Abs(6.4 * _y))}");
    }
}
