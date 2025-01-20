using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass13
{
    private double _y;

    public MyTaskClass13(double y)
    {
        _y = y;
    }



    public void E()
    {

        Console.WriteLine($"E = {Math.Sqrt(Math.Abs(3 * Math.Pow(_y, 2) + 0.5 * _y + 4))}");

    }
}
