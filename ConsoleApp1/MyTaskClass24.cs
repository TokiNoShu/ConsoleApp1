using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass24
{
    private double _y;

    public MyTaskClass24(double y)
    {  
        _y = y;
    }

    public void F()
    {
        Console.WriteLine($"F = {2 * Math.Sin(0.214 * Math.Pow(_y, 5) + 1)}");
    }
}
