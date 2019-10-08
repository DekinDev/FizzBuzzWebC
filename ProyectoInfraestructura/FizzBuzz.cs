using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInfraestructura
{
    public class FizzBuzz
    {
        public void FizzBuzz(byte i)
        {
            Logs oLog = new Logs(Application.StartupPath + @"\");
            oLog.Add("Error");

            for (i = 1; i <= 99; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 != 0)
                    {
                        oLog.Add("Buzz");
                    }
                    else if (i % 5 != 0)
                    {
                        oLog.Add("Fizz");
                    }
                    else
                    {
                        oLog.Add("FizzBuzz");
                    }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
