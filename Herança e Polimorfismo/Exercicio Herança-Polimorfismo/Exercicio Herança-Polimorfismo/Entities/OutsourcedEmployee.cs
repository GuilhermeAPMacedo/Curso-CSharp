﻿namespace Exercicio_Herança_Polimorfismo.Entities
{
    sealed class OutsourcedEmployee: Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double additionalCharge)
            : base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + AdditionalCharge *1.1;
        }
    }
}
