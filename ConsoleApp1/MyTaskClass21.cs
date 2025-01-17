using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass21
{
    private double _y;
    private double _e;
    private double _h;


    public MyTaskClass21(double y, double e, double h)
    {  
        _y = y;
        _e = e;
        _h = h;
    }

    public void P()
    {
        Console.WriteLine($"P = {Math.Pow(_e, _y + 5.5) + 9.1 * Math.Pow(_h, 3)}");
    }
}
