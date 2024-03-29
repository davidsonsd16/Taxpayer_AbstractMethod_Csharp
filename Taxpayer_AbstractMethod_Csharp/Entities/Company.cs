﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Taxpayer_AbstractMethod_Csharp.Entities {
    class Company : Taxpayer {
        public int NumberEmployees { get; set; }

        public Company(string name, double anualIncome, int numberEmployees)
            : base(name, anualIncome) {
            NumberEmployees = numberEmployees;
        }

        public override double Tax() {
            if (NumberEmployees > 10)
                return (AnualIncome * 0.14);
            else
                return (AnualIncome * 0.16);
        }
    }
}
