using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public static class Battle
    {
        public static void BatlleTransformer(Transformer transformerOne, Transformer transformerTwo)
        {
            Console.WriteLine("!!!Нехай битва розпочнеться!!!");

            transformerOne.Transform();
            transformerOne.Run();
            transformerOne.FindEnemy();
            transformerTwo.Transform();
            transformerTwo.Run();
            transformerTwo.FindEnemy();
            transformerOne.CaptureTheTarget(transformerTwo);
            transformerTwo.CaptureTheTarget(transformerOne);

            while (transformerOne.Health > 0 && transformerTwo.Health > 0)
                if (GreatRandom.GenerateWeapon() == 0)
                    transformerOne.ShootAtEnemy();
                else
                    transformerTwo.ShootAtEnemy();
            Console.WriteLine(transformerOne.Health > 0 ? $"{transformerOne.Name} !Переможець!" : $"{transformerTwo.Name} !Переможець!");
        }
    }
}
