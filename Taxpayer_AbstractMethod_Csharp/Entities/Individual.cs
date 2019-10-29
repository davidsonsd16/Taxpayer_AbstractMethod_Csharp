using System;
using System.Collections.Generic;
using System.Text;

namespace Taxpayer_AbstractMethod_Csharp.Entities {
    class Individual : Taxpayer {

        public double HealthExpenditure { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditure)
            : base(name, anualIncome) {
            HealthExpenditure = healthExpenditure;
        }

        public override double Tax() {
            if (AnualIncome < 20000.00)
                return (AnualIncome * 0.15) - (HealthExpenditure * 0.5);
            else
                return (AnualIncome * 0.25) - (HealthExpenditure * 0.5);
        }
    }
}
