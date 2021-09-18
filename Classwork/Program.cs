using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask 1\nОбласти значений численных типов данных:");
            
            Console.WriteLine("byte [{0}; {1}]", Byte.MinValue, Byte.MaxValue);
            Console.WriteLine("sbyte [{0}; {1}]", SByte.MinValue, SByte.MaxValue);
            Console.WriteLine("short [{0}; {1}]", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("ushort [{0}; {1}]", UInt16.MinValue, UInt16.MaxValue);
            Console.WriteLine("int [{0}; {1}]", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("uint [{0}; {1}]", UInt32.MinValue, UInt32.MaxValue);
            Console.WriteLine("long [{0}; {1}]", Int64.MinValue, Int64.MaxValue);
            Console.WriteLine("ulong [{0}; {1}]", UInt64.MinValue, UInt64.MaxValue);
            Console.WriteLine("float [{0}; {1}]", Single.MinValue, Single.MaxValue);
            Console.WriteLine("double [{0}; {1}]", Double.MinValue, Double.MaxValue);
            Console.WriteLine("decimal [{0}; {1}]", Decimal.MinValue, Decimal.MaxValue);
            //Console.WriteLine("char [{0}; {1}]", Char.MinValue, Char.MaxValue);


            Console.ReadKey();
        }
    }
}
