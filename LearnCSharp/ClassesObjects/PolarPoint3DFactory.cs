using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class PolarPoint3DFactory
    {
        public static PolarPoint3D FromDistanceAndAngle(double  distance,double angle)
        {
            return new PolarPoint3D(distance, angle, 0);
        }
        public static PolarPoint3D FromAngleAndAltitude(double angle, double altitude)
        {
            return new PolarPoint3D(0, angle, altitude);
        }
    }
}
