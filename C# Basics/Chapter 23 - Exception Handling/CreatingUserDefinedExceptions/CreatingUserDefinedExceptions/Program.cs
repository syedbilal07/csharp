using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingUserDefinedExceptions
{
    class Program
    {
        public class Temperature
        {
            int temperature = 0;
            public void showTemperature()
            {
                if(temperature == 0)
                {
                    throw (new TempIsZeroException("Zero Temperature Found"));
                }
                else
                {
                    Console.WriteLine("Temperature : {0} ", temperature);
                }
            }
        }
        public class TempIsZeroException : Exception
        {
            public TempIsZeroException(string message) : base(message)
            {

            }
        }

        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemperature();
            }
            catch(TempIsZeroException e)
            {
                Console.WriteLine("Zero Exception Caught : {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
