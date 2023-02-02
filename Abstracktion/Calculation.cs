using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracktion
{
    internal abstract class Calculation
    {
        public abstract int Operate(int x,int y);
    }



    internal sealed class Addition:Calculation
    {
        public override int Operate(int x,int y)
        {
            int res = x + y;
            Console.WriteLine($"Addition:First number={x} Second number={y} Result={res}");
            return x + y;
        }
    }
    internal sealed class Substraction:Calculation
    {
        public override int Operate(int x, int y)
        {
            int res = x - y;
            Console.WriteLine($"Substraction:First number={x} Second number={y} Result={res}");
            return x - y;
        }
    } 
    internal sealed class Multiplication:Calculation
    {
        public override int Operate(int x, int y)
        {
            int res = x * y;
            Console.WriteLine($"Multiplication:First number={x} Second number={y} Result={res}");
            return x * y;
        }
    }
    internal sealed class Division:Calculation
    {
        public override int Operate(int x, int y)
        {
            int res = x / y;
            Console.WriteLine($"Division:First number={x} Second number={y} Result={res}");
            return x / y;
        }
    }

}
