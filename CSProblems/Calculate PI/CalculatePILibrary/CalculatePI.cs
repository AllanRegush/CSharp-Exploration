using System;

namespace CalculatePILibrary
{
    public class CalculatePI
    {
        public CalculatePI() { }

        public double CalculatePi(int n)
        {
            double numerator = 4.0;
            double denominator = 1.0;
            double operation = 1.0;
            double pi = 0.0;
            for(int i = 0; i < n; ++i)
            {
                pi += operation * (numerator / denominator);
                denominator += 2.0;
                operation *= -1.0;
            }
            return pi;
        }
    }
}
