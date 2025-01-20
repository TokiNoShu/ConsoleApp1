using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass7
{
    private double _m;

    public MyTaskClass7(double m)
    {  
        _m = m; 
    }

    public void N()
    {
        Console.WriteLine($"N = {Math.Pow(_m, 2) + 2.8 * Math.Abs(_m) + 0.55}");
    }
}
