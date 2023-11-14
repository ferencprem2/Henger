using System;
namespace Henger
{
    public class Cso : Henger
    {
        private double falVastagsag;

        public double FalVastagsag { get { return falVastagsag; } }

        public Cso(double sugar, double magassag) : base(sugar, magassag)
        {
            falVastagsag = 1;
        }

        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public override double Terfogat()
        {
            double kulsoTerfogat = Math.PI * Math.Pow(sugar, 2) * magassag;
            double belsoTerfogat = Math.PI * Math.Pow((sugar - falVastagsag), 2) * magassag;
            return kulsoTerfogat - belsoTerfogat;
        }

        public override string ToString()
        {
            return base.ToString() + $" falVastagsag: {falVastagsag}";
        }
    }

}

