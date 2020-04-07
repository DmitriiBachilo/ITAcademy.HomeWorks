using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class SportBike : Motorcycle
    {
        public void TestMotorcycle()
        {
            this.MaxSpeedInternalProtected();
            MaxSpeedPrivateProtected();
        }
    }
}
