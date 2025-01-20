using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass8
{
    private double _y;

    public MyTaskClass8(double y)
    {  
        _y = y; 
    }

    public void T()
    {
        Console.WriteLine($"T = {Math.Sqrt(Math.Abs(6 * Math.Pow(_y, 2) - 0.1 * _y + 4))}");
    }
}
