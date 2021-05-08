using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public abstract class Transformer
    {
        public string Name { get; }
        protected bool IsVehicle = false;
        protected readonly Weapon Weapon;
        protected readonly Scanner Scanner;
        public int Health { get; protected set; }
        protected Transformer EnemyTransformer;

        protected Transformer(string name, Weapon weapon, Scanner scanner)
        {
            Name = name;
            Weapon = weapon;
            Scanner = scanner;
            Health = 200;
        }
        public abstract void Fire();

        public abstract void ReloadWeapon();

        public abstract void Transform();

        public abstract void Run();

        public abstract void FindEnemy();

        public abstract void ShootAtEnemy();

        public abstract void GetUron(int damage);

        public abstract void CaptureTheTarget(Transformer transformer);

        public abstract void ShowStatus();

    }
}
