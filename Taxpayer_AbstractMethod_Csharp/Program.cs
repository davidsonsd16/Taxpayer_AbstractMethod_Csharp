using System;
using System.Collections.Generic;
using Taxpayer_AbstractMethod_Csharp.Entities;

namespace Taxpayer_AbstractMethod_Csharp {
    class Program {
        static void Main(string[] args) {
            List<Taxpayer> list = new List<Taxpayer>();
            list.Add(new Individual("Alex", 50000.00, 2000.00));
            list.Add(new Company("Alex", 50000.00, 20));

            foreach(Taxpayer taxpayer in list) {
                Console.WriteLine(taxpayer);
            }
            
        }
    }
}
