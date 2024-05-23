using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dMark;
            double dMaxMark = 0;
            int iCountPass = 0;
            int iCountFail = 0;
            int iIndex = 0;
            string sName;
            string sMaxName = " ";
            double dSum = 0;
           double dPercentage;

            while (IsANotherOne())
            {
                iIndex++;

                Console.Write("Name : ");
                sName = Console.ReadLine();
                Console.Write("Mark : ");
                dMark = double.Parse(Console.ReadLine());
                dPercentage = Percentage(dMark);
                Console.Write("Percentage : " + dPercentage);
                Console.WriteLine("\n");

                if (dPercentage < 50)
                {
                    iCountFail++;
                }
                else
                {
                    iCountPass++;
                }

                dSum+= dPercentage;

                if (dMark > dMaxMark)
                {
                    dMaxMark = dMark;
                    sMaxName = sName;
                }
                
            }

            double dAverage = dSum * 1.0 / iIndex;

            Console.Clear();
            Console.WriteLine("\n\tSummary");
            Console.WriteLine("\t-------");
            Console.WriteLine("\nNumber Passed\t: " + iCountPass);
            Console.WriteLine("Number Failed\t: " + iCountFail);
            Console.WriteLine("Best Perfoming student\t: " + sMaxName + " < " + Percentage(dMaxMark) + "% >");
            Console.WriteLine("Class Average : " + dAverage + "% ");
            Console.WriteLine("\nPress any key to exit!!");
            Console.ReadKey();
        }
        static bool IsANotherOne()
        {
            Console.Write("Another one (Y/N) ? ");
            return Console.ReadLine().ToUpper() == "Y";
        }
        static double Percentage(double _dMark)
        {
            return Math.Round(_dMark/66 *100,1);
        }
    }
}
