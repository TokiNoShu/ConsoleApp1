using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass30
{
    private double _y;
    private double _r;
    private double _e;

    public MyTaskClass30(double y, double r, double e)
    {  
        _y = y;
        _e = e;
        _r = r;
    }

    public void W()
    {
        Console.WriteLine($"W = {Math.Pow(_e, _y + _r) + 7.2 * Math.Sin(_r)}");
    }
}
