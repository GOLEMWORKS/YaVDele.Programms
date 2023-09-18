using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaVDele.CalculatorGrant.Data
{
    public class Calculations
    {
        public string init()
        {
            string r = "calculations initialized";
            return r;
        }

        public double CalculateSofinans(double grantAmount, double teamHelp) 
        {
            double res = Math.Round((grantAmount + teamHelp) * 30 / 100, 2);
            return res;
        }
    }
}
