using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass14
{
    private double _y;
    private double _x;
    private double _e;

    public MyTaskClass14(double y, double x, double e)
    {
        _y = y;
        _x = x;
        _e = e;
    }



    public void R()
    {

        Console.WriteLine($"R = {Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(_y), 2) + 6.835 + Math.Pow(_e, _x)))}");

    }
}
