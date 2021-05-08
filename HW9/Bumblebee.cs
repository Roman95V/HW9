using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class Bumblebee : FlyingTransformer
    {
        public Bumblebee(string name, Weapon weapon, Scanner scanner) : base(name, weapon, scanner) { }

        public override void Fire()
        {
            Console.Write($"{Name} стріляє  з ");
            Weapon.Fire();
        }

        public override void ReloadWeapon()
        {
            Console.Write($"{Name} перезаряджає ");
            Weapon.Reload();
        }

        public override void Transform()
        {
            IsVehicle = !IsVehicle;
            Console.WriteLine($"{Name} трансформер");
        }

        public override void Run()
        {
            Console.WriteLine($"{Name} - біжить");
        }

        public override void FindEnemy()
        {
            Console.Write($"{Name} Сканує з ");
            Scanner.Scan();
        }

        public override void ShootAtEnemy()
        {
            var uron = GreatRandom.GenerateUron();

            if (Weapon.GetChargeCritCounter() == 2)
            {
                Fire();
                EnemyTransformer.GetUron(uron * 4);
                Console.WriteLine($" {Name} - Наносить !Критичний Урон: {uron * 4}!");
                Weapon.ResetChargeCritCounter();
            }
            else
            {
                Fire();
                EnemyTransformer.GetUron(uron);
                Console.WriteLine($"{Name} - Наносить !Урон: {uron}!");
            }
        }

        public override void GetUron(int damage)
        {
            Health -= damage;
        }

        public override void CaptureTheTarget(Transformer transformer)
        {
            EnemyTransformer = transformer;
        }

        public override void ShowStatus()
        {
            Console.WriteLine($"Броня: {Health}");
        }

        public override void Fly()
        {

        }
    }
}
