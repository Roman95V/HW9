using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public abstract class DriverTransformer : Transformer
    {
        protected DriverTransformer(string name, Weapon weapon, Scanner scanner) : base(name, weapon, scanner) { }

        public abstract void Drive();
    }
}
