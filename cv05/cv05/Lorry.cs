using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    public class Lorry : Car
    {
        private double transportedLoad;

        public double MaxLoad { get; private set; }

        public double TransportedLoad
        {
            get { return this.transportedLoad; }
            set
            {
                if (value > this.MaxLoad)
                throw new ArgumentOutOfRangeException("Load is over limit");

                this.transportedLoad = value;
            }
        }


        public Lorry(double sizeOfTank, TypeOfFuel fuel, double maxLoad, double stateOfTank = 0, double transportedLoad = 0)
        : base(sizeOfTank, fuel, stateOfTank)
        {
            maxLoad = maxLoad;
            TransportedLoad = transportedLoad;
        }

        private double CheckTransportedLoad(double load)
        {

        }
        public override string ToString()
        {
            return String.Format("{0}Actual transported load is {1}.", base.ToString(), TransportedLoad);
        }
    }
}
