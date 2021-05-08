using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class RocketWeapon : Weapon
    {
        public RocketWeapon()
        {
            Ammo = 3;
        }

        public override void Reload()
        {
            Console.WriteLine("Перезавантажте ракетну зброю");
            Ammo = 3;
        }

        public override void Fire()
        {
            if (Ammo > 0)
            {
                Console.WriteLine("Ракетної зброї");
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
