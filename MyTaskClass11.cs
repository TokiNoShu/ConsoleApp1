using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass11
{
    private double _y;
    private double _x;

    public MyTaskClass11(double y, double x)
    {
        _y = y;
        _x = x;
    }



    public void S()
    {

        Console.WriteLine($"S = {9.765 * Math.Pow(_y, 7) + 2 * Math.Tan(_x)}");

    }
}
