using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9._2
{
    public class ConvertManny : ConvertInGRN
    {
        public void ConverInDolar()
        {

            double result;

            double dolar = 28;

            result = total / dolar;

            Console.WriteLine($"Результат - {Math.Round(result, 2)} доларів.");

        }
        public void ConverInEvro()
        {
            double result;

            double evro = 33;

            result = total / evro;

            Console.WriteLine($"Результат - {Math.Round(result, 2)} евро.");
        }
        public void ConvertInZlot()
        {
            double result;

            double zlot = 7.17;

            result = total / zlot;

            Console.WriteLine($"Результат - {Math.Round(result, 2)} злот.");
        }
        public void ConvertInRuble()
        {
            double result;

            double ruble = 0.36;

            result = total / ruble;

            Console.WriteLine($"Результат - {Math.Round(result, 2)} рублів.");
        }
        public void ConvertInPound()
        {
            double result;

            double pound = 37.5;

            result = total / pound;

            Console.WriteLine($"Результат - {Math.Round(result, 2)} фунтів.");
        }
        public void OutGrn()
        {
            Console.WriteLine($"Результат - {Math.Round(total, 2)} грн.");
        }
    }
}
