using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class FireStation: IClockIn
    {
        List<INamedPerson> clockedInStaff = new List<INamedPerson>();
        public void ClockIn(INamedPerson staffMember)
        {
            if(!clockedInStaff.Contains(staffMember))
            {
                clockedInStaff.Add(staffMember);
                Console.WriteLine("Clocked in {0}", staffMember.Name);
            }
        }
        public void RollCall()
        {
            foreach(INamedPerson staffMember in clockedInStaff)
            {
                Console.WriteLine( staffMember.Name);
            }
        }
        public void ClockIn(object item)
        {
            INamedPerson namedPerson = item as INamedPerson;
            if(namedPerson !=null)
            {
                ClockIn(namedPerson);
            }
            else
            {
                Console.WriteLine("We can't check in a {0}", item.GetType());
            }
        }

    }
}
