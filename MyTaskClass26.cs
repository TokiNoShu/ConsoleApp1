using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass26
{
    private double _p;

    public MyTaskClass26(double p)
    {  
        _p = p;
    }

    public void Z()
    {
        Console.WriteLine($"Z = {Math.Sin(Math.Pow(Math.Pow(_p, 2) + 0.4, 3))}");
    }
}
