using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass15
{
    private double _y;

    public MyTaskClass15(double y)
    {
        _y = y;
    }



    public void H()
    {

        Console.WriteLine($"H = {Math.Sin(Math.Pow(_y, 2)) - 2.8 * _y + Math.Sqrt(Math.Abs(_y))}");

    }
}
