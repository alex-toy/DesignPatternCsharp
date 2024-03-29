﻿namespace BridgeWrong
{
    public class Machine_B_D_C : Machine
    {
        public double TaxCoefficient { get; set; }

        public override double CalculateTaxes()
        {
            return BasePrice * TaxCoefficient;
        }

        public override string GetEnvironmentalCategory()
        {
            return "D";
        }

        public override double CalculateInsuranceFee()
        {
            return BasePrice / 13.0;
        }
    }
}
