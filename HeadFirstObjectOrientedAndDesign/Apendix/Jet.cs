using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstObjectOrientedAndDesign.Apendix
{
    internal class Jet : AirPlane
    {
        static int MULTIPIER = 2;
        public override void SetSpedd(int speed) =>
            base.SetSpedd(speed * MULTIPIER);
        public void Accelerate() =>
            base.SetSpedd(GetSpedd() * 2);
    }
}
