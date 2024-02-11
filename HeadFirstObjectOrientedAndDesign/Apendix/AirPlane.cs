using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstObjectOrientedAndDesign.Apendix
{
    internal class AirPlane
    {
        int speed;
        public virtual void SetSpedd(int speed) =>
            this.speed = speed;
        public virtual int GetSpedd() => 
            this.speed;
    }
}
