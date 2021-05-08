using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public static class Menu
    {
        public static void Start()
        {
            var transformers = new List<Transformer>();

            while (transformers.Count < 2)
            {
                Console.WriteLine($"Створіть трансформера №{transformers.Count + 1}!");
                Console.WriteLine("Введіть ім'я: ");
                var name = Console.ReadLine();
                Console.WriteLine("Виберіть тип трансформера: (1) OptimusPrime. (2) Bumblebee");
                var typeNumber = Console.ReadLine();
                Console.WriteLine("Виберіть зброю: (1) Лазер. (2) Ракети");
                var weaponNumber = Console.ReadLine();
                Console.WriteLine("Виберіть сканер: (1) Оптичний. (2) Гідролокатор");
                var scannerNumber = Console.ReadLine();
                Weapon weapon = weaponNumber switch
                {
                    "1" => new LaserWeapon(),
                    "2" => new RocketWeapon(),

                };

                Scanner scanner = scannerNumber switch
                {
                    "1" => new OpticalScanner(),
                    "2" => new Sonar(),

                };

                switch (typeNumber)
                {
                    case "1":
                        transformers.Add(new OptimusPrime(name, weapon, scanner));
                        break;
                    case "2":
                        transformers.Add(new Bumblebee(name, weapon, scanner));
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
            Battle.BatlleTransformer(transformers[0], transformers[1]);

        }
    }
}
