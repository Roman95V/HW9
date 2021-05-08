using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9._2
{
    public class SelectAction
    {
        public void Menu()
        {
            Console.WriteLine("Ви вже увійшли в програму Конвертація валют. Будь ласка, оберіть  валюту з якої Ви хочете перевести: \n " +
                "(1) Долар, (2) Євро, (3) Злот, (4) Рубиль, (5) Фунт");

            var convertgrn = new ConvertInGRN();

            switch (Console.ReadLine())
            {
                case "1": convertgrn.ConvertWithDolar(); break;
                case "2": convertgrn.ConverWithEvro(); break;
                case "3": convertgrn.ConvertWithZlot(); break;
                case "4": convertgrn.ConvertWithRuble(); break;
                case "5": convertgrn.ConvertWithPound(); break;
                default: throw new ArgumentException($"Invalid operation.");
            }

            Console.WriteLine("Будь ласка, оберіть валюту в яку Ви хочете перевести :\n (1) Долар, (2) Євро," +
                            " (3) Злот, (4) Рубиль, (5) Фунт, (6) Гривня ");

            var convertincurrency = new ConvertManny();

            switch (Console.ReadLine())
            {
                case "1": convertincurrency.ConverInDolar(); break;
                case "2": convertincurrency.ConverInEvro(); break;
                case "3": convertincurrency.ConvertInZlot(); break;
                case "4": convertincurrency.ConvertInRuble(); break;
                case "5": convertincurrency.ConvertInPound(); break;
                case "6": convertincurrency.OutGrn(); break;
                default: throw new ArgumentException($"Invalid operation.");
            }
        }
    }
}
