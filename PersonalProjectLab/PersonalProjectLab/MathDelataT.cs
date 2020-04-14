using System;
namespace PersonalProjectLab
{
    public class MathDelataT
    {
        public MathDelataT()
        {
        }
        public double CalculateKb(double vhf, double molality, double kb)
        {
             // vhf * molality *kb + 100

                double myBoilingPoint = vhf * molality * kb + 100;
            return myBoilingPoint;
        }
        public double CalculateKf(double vhf, double molality, double kf)
        {
            // vhf * molality *kf + 100

            double myFreezingPoint = 00.0 - (vhf * molality * kf);
            return myFreezingPoint;
        }
    }
}
