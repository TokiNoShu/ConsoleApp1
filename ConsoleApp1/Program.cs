using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №1");
            Console.WriteLine("1-30");
            int sm = Convert.ToInt32(Console.ReadLine());

            switch (sm)
            {
                case 1:
                    double t, l, R;

                    Console.WriteLine("Введите значение t");
                    t = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение l");
                    l = Convert.ToDouble(Console.ReadLine());
                    //R = 3*Math.Pow(t,2)+3*Math.Pow(l,5)+4.9;
                    //Console.WriteLine($"R = {R}");
                    MyTaskClass1 myTaskClass1 = new MyTaskClass1(t, l);
                    myTaskClass1.R();
                    break;

                case 2:
                    double K, p, y, e;

                    Console.WriteLine("Введите значение p");
                    p = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    //K = Math.Log(Math.Pow(p, 2) + Math.Pow(y, 3) + Math.Pow(e, p));
                    //Console.WriteLine($"K = {K}");
                    MyTaskClass2 myTaskClass2 = new MyTaskClass2(p, y, e);
                    myTaskClass2.K();
                    break;

                case 3:
                    double G, n;

                    Console.WriteLine("Введите значение n");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    //G = n * (y + 3.5) + Math.Sqrt(y);
                    //Console.WriteLine($"G = {G}");
                    MyTaskClass3 myTaskClass3 = new MyTaskClass3(n, y);
                    myTaskClass3.G();
                    break;

                case 4:
                    double D, a;

                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение t");
                    t = Convert.ToDouble(Console.ReadLine());
                    //D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(t, 5));
                    //Console.WriteLine($"D = {D}");
                    MyTaskClass4 myTaskClass4 = new MyTaskClass4(a, t);
                    myTaskClass4.D();
                    break;

                case 5:
                    double L, x;

                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    //L = 1.51 * Math.Cos(Math.Pow(x, 2)) + 2 * Math.Pow(x, 3);
                    //Console.WriteLine($"L = {L}");
                    MyTaskClass5 myTaskClass5 = new MyTaskClass5(x);
                    myTaskClass5.L();
                    break;

                case 6:
                    double M;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    //M = Math.Cos(2) * y + 3.6 * Math.Pow(e, x);
                    //Console.WriteLine($"M = {M}");
                    MyTaskClass6 myTaskClass6 = new MyTaskClass6(y, e, x);
                    myTaskClass6.M();
                    break;

                case 7:
                    double N, m;

                    Console.WriteLine("Введите значение m");
                    m = Convert.ToDouble(Console.ReadLine());
                    //N = Math.Pow(m, 2) + 2.8 * Math.Abs(m) + 0.55;
                    //Console.WriteLine($"N = {N}");
                    MyTaskClass7 myTaskClass7 = new MyTaskClass7(m);
                    myTaskClass7.N();
                    break;

                case 8:
                    double T;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    //T = Math.Sqrt(Math.Abs(6 * Math.Pow(y, 2) - 0.1 * y + 4));
                    //Console.WriteLine($"T = {T}");
                    MyTaskClass8 myTaskClass8 = new MyTaskClass8(y);
                    myTaskClass8.T();
                    break;

                case 9:
                    double V;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    //V = Math.Log(y+0.95)+ Math.Sin(Math.Pow(x, 4));
                    //Console.WriteLine($"V = {V}");
                    MyTaskClass9 myTaskClass9 = new MyTaskClass9(y, x);
                    myTaskClass9.V();
                    break;

                case 10:
                    double U, k;

                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение k");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    //U = Math.Pow(e, y)+7.355* Math.Pow(k, 2)+ Math.Pow(Math.Sin(x),2);
                    //Console.WriteLine($"U = {U}");
                    MyTaskClass10 myTaskClass10 = new MyTaskClass10(e, y, k, x);
                    myTaskClass10.U();
                    break;

                case 11:
                    double S;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    //S = 9.765 * Math.Pow(y, 7) + 2 * Math.Tan(x);
                    //Console.WriteLine($"S = {S}");
                    MyTaskClass11 myTaskClass11 = new MyTaskClass11(y, x);
                    myTaskClass11.S();
                    break;

                case 12:

                    Console.WriteLine("Введите значение t");
                    t = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    //K = 7*Math.Pow(t, 2)+ 3 * Math.Sin(Math.Pow(x, 3)) + 9.2;
                    //Console.WriteLine($"K = {K}");
                    MyTaskClass12 myTaskClass12 = new MyTaskClass12(t, x);
                    myTaskClass12.K();
                    break;

                case 13:
                    double E;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    //E = Math.Sqrt(Math.Abs(3 * Math.Pow(y, 2) + 0.5 * y + 4));
                    //Console.WriteLine($"E = {E}");
                    MyTaskClass13 myTaskClass13 = new MyTaskClass13(y);
                    myTaskClass13.E();
                    break;

                case 14:

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    //R = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y),2)+6.835+ Math.Pow(e, x)));
                    //Console.WriteLine($"R = {R}");
                    MyTaskClass14 myTaskClass14 = new MyTaskClass14(y, e, x);
                    myTaskClass14.R();
                    break;

                case 15:
                    double H;

                    Console.WriteLine("Введите значение t");
                    y = Convert.ToDouble(Console.ReadLine());
                    //H = Math.Sin(Math.Pow(y, 2)) - 2.8 * y + Math.Sqrt(Math.Abs(y));
                    //Console.WriteLine($"H = {H}");
                    MyTaskClass15 myTaskClass15 = new MyTaskClass15(y);
                    myTaskClass15.H();
                    break;

                case 16:

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    //S = Math.Sqrt(Math.Cos(4* Math.Pow(y, 2))+7.151);
                    //Console.WriteLine($"S = {S}");
                    MyTaskClass16 myTaskClass16 = new MyTaskClass16(y);
                    myTaskClass16.S();
                    break;

                case 17:

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    //N = 3* Math.Pow(y,2)+ Math.Sqrt(y+1);
                    //Console.WriteLine($"N = {N}");
                    MyTaskClass17 myTaskClass17 = new MyTaskClass17(y);
                    myTaskClass17.N();
                    break;

                case 18:
                    double Z;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    //Z = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Pow(y, 3) + 1);
                    //Console.WriteLine($"Z = {Z}");
                    MyTaskClass18 myTaskClass18 = new MyTaskClass18(y);
                    myTaskClass18.Z();
                    break;

                case 19:
                    double P, g;

                    Console.WriteLine("Введите значение n");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение g");
                    g = Convert.ToDouble(Console.ReadLine());
                    //P = n * Math.Sqrt(Math.Pow(y,3)+1.09 * g);
                    //Console.WriteLine($"P = {P}");
                    MyTaskClass19 myTaskClass19 = new MyTaskClass19(n, y, g);
                    myTaskClass19.P();
                    break;

                case 20:

                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение k");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    //U = Math.Pow(e, k+y) + Math.Tan(x*Math.Sqrt(y));
                    //Console.WriteLine($"U = {U}");
                    MyTaskClass20 myTaskClass20 = new MyTaskClass20(e, k, y, x);
                    myTaskClass20.U();
                    break;

                case 21:
                    double h;

                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение h");
                    h = Convert.ToDouble(Console.ReadLine());
                    //P = Math.Pow(e, y+5.5)+ 9.1* Math.Pow(h,3);
                    //Console.WriteLine($"P = {P}");
                    MyTaskClass21 myTaskClass21 = new MyTaskClass21(e, y, h);
                    myTaskClass21.P();
                    break;

                case 22:
                    double u;

                    Console.WriteLine("Введите значение u");
                    u = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    //T = Math.Sin(2*u)* Math.Log(2* Math.Pow(y, 2)+ Math.Sqrt(x));
                    //Console.WriteLine($"T = {T}");
                    MyTaskClass22 myTaskClass22 = new MyTaskClass22(u, y, x);
                    myTaskClass22.T();
                    break;

                case 23:
                    double f;

                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение f");
                    f = Convert.ToDouble(Console.ReadLine());
                    //G = Math.Pow(e, 2*y) + Math.Sin(f);
                    //Console.WriteLine($"G = {G}");
                    MyTaskClass23 myTaskClass23 = new MyTaskClass23(e, y, f);
                    myTaskClass23.G();
                    break;

                case 24:
                    double F;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    //F = 2 * Math.Sin(0.214* Math.Pow(y,5)+1);
                    //Console.WriteLine($"F = {F}");
                    MyTaskClass24 myTaskClass24 = new MyTaskClass24(y);
                    myTaskClass24.F();
                    break;

                case 25:

                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение f");
                    f = Convert.ToDouble(Console.ReadLine());
                    //G = Math.Pow(e, 2 * y) + Math.Sin(Math.Pow(f,2));
                    //Console.WriteLine($"G = {G}");
                    MyTaskClass25 myTaskClass25 = new MyTaskClass25(e, y, f);
                    myTaskClass25.G();
                    break;

                case 26:

                    Console.WriteLine("Введите значение p");
                    p = Convert.ToDouble(Console.ReadLine());
                    //Z = Math.Sin(Math.Pow(Math.Pow(p,2)+0.4,3));
                    //Console.WriteLine($"Z = {Z}");
                    MyTaskClass26 myTaskClass26 = new MyTaskClass26(p);
                    myTaskClass26.Z();
                    break;

                case 27:
                    double W, v;

                    Console.WriteLine("Введите значение v");
                    v = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    //W = 1.03 * v + Math.Pow(e, 2*y) + Math.Tan(Math.Abs(x));
                    //Console.WriteLine($"W = {W}");
                    MyTaskClass27 myTaskClass27 = new MyTaskClass27(v, e, y, x);
                    myTaskClass27.W();
                    break;

                case 28:

                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение h");
                    h = Convert.ToDouble(Console.ReadLine());
                    //T = Math.Pow(e,y+h)+ Math.Sqrt(Math.Abs(6.4*y));
                    //Console.WriteLine($"T = {T}");
                    MyTaskClass28 myTaskClass28 = new MyTaskClass28(e, y, h);
                    myTaskClass28.T();
                    break;

                case 29:
                    double r;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    //N = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Abs(y + 1));
                    //Console.WriteLine($"N = {N}");
                    MyTaskClass29 myTaskClass29 = new MyTaskClass29(y);
                    myTaskClass29.N();
                    break;

                case 30:

                    Console.WriteLine("Введите значение e");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение r");
                    r = Convert.ToDouble(Console.ReadLine());
                    //W = Math.Pow(e, y + r) + 7.2*Math.Sin(r);
                    //Console.WriteLine($"W = {W}");
                    MyTaskClass30 myTaskClass30 = new MyTaskClass30(e, y, r);
                    myTaskClass30.W();
                    break;
            }
        }
    }
}