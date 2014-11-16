using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class FireFighter: FireFighterBase
    {
        public override void ExtinguishFire()
        {
            Console.WriteLine("{0} is putting out the fire!", Name);
            TrainHoseOnFire();
            TurnOnHose();

        }
        protected virtual void TurnOnHose()
        {
            Console.WriteLine("The fire is going out.");
        }
        protected virtual void TrainHoseOnFire()
        {
            Console.WriteLine("Training the hose on the fire test");
        }
    }
}
