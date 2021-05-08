using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9._2
{
    public class ConvertInGRN
    {
        public static double total;
        public void ConvertWithDolar()
        {
            double dolar = 27.8;

            Console.WriteLine("Ведіть суму: ");
            double manny = Convert.ToDouble(Console.ReadLine());

            if (manny > 0)

                total = manny * dolar;
            else
                Console.WriteLine("Ви ввели відємну суму: " + manny);
        }
        public void ConverWithEvro()
        {
            double evro = 32.65;

            Console.WriteLine("Ведіть суму: ");
            double manny = Convert.ToDouble(Console.ReadLine());

            if (manny > 0)

                total = manny * evro;
            else
                Console.WriteLine("Ви ввели  від'ємну суму: " + manny);
        }
        public void ConvertWithZlot()
        {
            double zlot = 6.93;

            Console.WriteLine("Ведіть суму: ");
            double manny = Convert.ToDouble(Console.ReadLine());

            if (manny > 0)
                total = manny * zlot;
            else
                Console.WriteLine("Ви ввели  від'ємну суму: " + manny);
        }
        public void ConvertWithRuble()
        {
            double ruble = 0.34;

            Console.WriteLine("Ведіть суму: ");
            double manny = Convert.ToDouble(Console.ReadLine());

            if (manny > 0)
                total = manny * ruble;
            else
                Console.WriteLine("Ви ввели  від'ємну суму: " + manny);
        }
        public void ConvertWithPound()
        {
            double pound = 37.5;

            Console.WriteLine("Ведіть суму: ");
            double manny = Convert.ToDouble(Console.ReadLine());

            if (manny > 0)
                total = manny * pound;
            else
                Console.WriteLine("Ви ввели від'ємну суму: " + manny);
        }
    }
}
