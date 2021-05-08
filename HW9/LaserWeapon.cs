using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class LaserWeapon : Weapon
    {
        public LaserWeapon()
        {
            Ammo = 5;
        }

        public override void Reload()
        {
            Console.WriteLine("Перезавантажте лазерну зброю");
            Ammo = 5;
        }

        public override void Fire()
        {
            if (Ammo > 0)
            {
                Console.WriteLine("Лазерної зброї");
                Ammo--;
                ChargeCritCounter++;
            }
            else
                Reload();
        }

        public override void ResetChargeCritCounter()
        {
            ChargeCritCounter = 0;
        }

        public override int GetChargeCritCounter()
        {
            return ChargeCritCounter;
        }
    }
}
