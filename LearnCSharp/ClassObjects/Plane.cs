using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Plane
    {

       
        public string Identifier
        {
            get;
            set;


        }
       
        
        public double SpeedInKilometersPerHour
        {
            get;
            set;
        }
        const double kilometersPerMile = 1.609344;
        public double SpeedInMilesPerHour
        {
            get
            {
                return SpeedInKilometersPerHour / kilometersPerMile;
            }
            set
            {
                
                SpeedInKilometersPerHour = value * kilometersPerMile;
            }
        }
         public DirectionOfApproach Direction
         {
             get;
             set;
         }
         
        public enum DirectionOfApproach : int
        {
            Approaching=0,
            Leaving=1
        }
        public PolarPoint3D Position
        {
            get;
            set;
        }

        
        public void SendMessage(string messageText)
        {
            SendMessage(messageText, TimeSpan.Zero);
        }
        public void SendMessage(string messageText,TimeSpan delay)
        {

        }
    }
}
