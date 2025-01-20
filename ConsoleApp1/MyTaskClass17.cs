using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass17
{
    private double _y;

    public MyTaskClass17(double y)
    {  
        _y = y;
    }

    public void N()
    {
        Console.WriteLine($"N = {3 * Math.Pow(_y, 2) + Math.Sqrt(_y + 1)}");
    }
}
