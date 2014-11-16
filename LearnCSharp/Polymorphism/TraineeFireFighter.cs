using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class TraineeFireFighter: FireFighter
    {
        private bool hoseTrainedOnFire;
        protected override void TurnOnHose()
        {
           if (hoseTrainedOnFire)
           {
               Console.WriteLine("This fire is going out");
           }
           else
           {
               Console.WriteLine("There's water going everywhere!");
           }
        }
        protected override void TrainHoseOnFire()
        {
            hoseTrainedOnFire = true;
            Console.WriteLine("Training the hose on the fire");
        }
    }
}
