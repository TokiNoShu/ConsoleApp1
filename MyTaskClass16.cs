using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass16
{
    private double _y;

    public MyTaskClass16(double y)
    {  
        _y = y;
    }

    public void S()
    {
        Console.WriteLine($"S = {Math.Sqrt(Math.Cos(4 * Math.Pow(_y, 2)) + 7.151)}");
    }
}
