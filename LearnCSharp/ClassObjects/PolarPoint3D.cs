using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    struct PolarPoint3D
    {
        //prevent code duplication
        public PolarPoint3D(double distance,double angle)
            :this(distance,angle,0)
        {

        }
        public PolarPoint3D(double distance,double angle, double altitude)
            :this()
        {
            Distance = distance;
            Angle = angle;
            Altitude = altitude;
        }
        public double Distance
        {
            get;
            private set;
        }
        public double Angle
        {
            get;
            private set;
        }

        public double Altitude
        {
            get;
            private set;
        }
    }
}
