using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public static class GreatRandom
    {
        private static readonly Random _random = new Random();
        public static int GenerateWeapon()
        {
            return _random.Next(0, 2);
        }
        public static int GenerateUron()
        {
            return _random.Next(5, 26);
        }


    }
}
