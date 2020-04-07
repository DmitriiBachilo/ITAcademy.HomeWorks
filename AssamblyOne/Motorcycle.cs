namespace AssemblyOne
{
    class Motorcycle
    {
        public const ushort MaxSpeed = 350;
        public const byte MaxPowerBHP = 255;

        public const string Honda = "Honda";
        public const string Ducati = "Ducati";

        private int speed;
        private string color = "black";

        private int MaxSpeedPrivate;
        internal int MaxSpeedInternal;

        public void Exploitation()
        {

        }

        public void Service()
        {

        }

        private protected void MaxSpeedPrivateProtected()
        {

        }
        protected internal void MaxSpeedInternalProtected()
        {

        }

    }
}
