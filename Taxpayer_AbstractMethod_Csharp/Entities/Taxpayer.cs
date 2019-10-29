using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Taxpayer_AbstractMethod_Csharp.Entities {
    abstract class Taxpayer {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        
        public Taxpayer() { }

        protected Taxpayer(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString() {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
