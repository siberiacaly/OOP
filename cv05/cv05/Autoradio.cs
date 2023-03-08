using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    internal class Autoradio
    {
        private Dictionary<int, double> preset = new Dictionary<int, double>();

        public double Frequency { get; set; }

        public bool TurnOn { get; set; }

        public Autoradio(double frequency = 107.00)
        {
            Frequency = frequency;
            TurnOn = false;
        }

        public void AddPreset(int index, double frequency)
        {
            if (!preset.ContainsKey(index))
            {
                this.preset.Add(index, frequency);
            }
            else
            {
                this.preset[index] = frequency;
            }
        }

        public void TurnRadioFromPreset(int index)
        {
            if (preset.TryGetValue(index, out double value))
            {
                this.Frequency = value;
            }
            else
            {
                throw new Exception("Not in preset");
            }
        }

        public override string ToString()
        {
            if (TurnOn == false)
            {
                return "Radio is turned off";
            }
            else
            {
                return String.Format("Radio frequency is {0, 0:N2}", Frequency);
            }
        }
    }
}
