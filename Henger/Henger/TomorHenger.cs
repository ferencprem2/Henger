using System;
namespace Henger
{
    public class TomorHenger : Henger
    {
        private double fajsuly;

        public double GetFajsuly { get => fajsuly; }
        public double Suly { get => Terfogat() * fajsuly; }

        public TomorHenger(double sugar, double magassag) : base(sugar, magassag)
        {
            fajsuly = 7.87;
        }

        public TomorHenger(double sugar, double magassag, double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public override string ToString()
        {
            return base.ToString() + $" fajsúly:{fajsuly}";
        }
    }
}

