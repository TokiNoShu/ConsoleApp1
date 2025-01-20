using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass18
{
    private double _y;

    public MyTaskClass18(double y)
    {  
        _y = y;
    }

    public void Z()
    {
        Console.WriteLine($"Z = {3 * Math.Pow(_y, 2) + Math.Sqrt(Math.Pow(_y, 3) + 1)}");
    }
}
