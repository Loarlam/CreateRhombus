/*В консольке вводим числовое значение линий до центральной линии ромба*/
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)                                                             
        {
            int granica = Convert.ToInt32(Console.ReadLine()),                                      
                counterProbelov = granica,                                                          
                dGranica = (2 * granica) - 1;

            for (int stolbec = 0; stolbec < granica; stolbec++)                                     
            {
                counterProbelov -= 1;                                                               
                for (int probeliStroki = counterProbelov; probeliStroki > 0; probeliStroki--)       
                {
                    Console.Write(" ");
                }
                for (int zvezdiStroki = 0; zvezdiStroki < 2 * stolbec + 1; zvezdiStroki++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                if (stolbec == granica-1)
                {
                    int dCounterProbelov = counterProbelov;
                    for (int dStolbec = stolbec + 1; dStolbec < dGranica; dStolbec++)
                    {
                        dCounterProbelov += 1;
                        for (int dProbeliStroki = 0; dProbeliStroki < dCounterProbelov; dProbeliStroki++)
                        {
                            Console.Write(" ");
                        }
                        for (int dZvezdiStroki = dStolbec*2; dZvezdiStroki < dGranica*2-1; dZvezdiStroki++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
