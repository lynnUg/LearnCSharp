using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Firetruck
    {
        public FireFighter Driver {get; set;}
        public void Drive(Point coordinates)
        {
          if (Driver==null)
          {
              return;
          }
          Console.WriteLine("Driving to {0}", coordinates);
        }

    }
}
