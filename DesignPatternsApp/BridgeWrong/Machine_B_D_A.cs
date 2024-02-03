using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeWrong
{
    internal class Machine_B_D_A : Machine
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
            return BasePrice / 12.0;
        }
    }
}
