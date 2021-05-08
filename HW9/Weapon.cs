using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public abstract class Weapon
    {
        protected int Ammo;

        protected int ChargeCritCounter { get; set; }

        public abstract void Reload();

        public abstract void Fire();

        public abstract void ResetChargeCritCounter();

        public abstract int GetChargeCritCounter();

    }
}
