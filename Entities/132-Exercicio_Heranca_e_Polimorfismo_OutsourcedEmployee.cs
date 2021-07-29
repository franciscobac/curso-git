namespace ExerciciosCursoCSharp.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionCharge) :base(name, hours, valuePerHour)
        {
            AdditionCharge = additionCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionCharge;
        }
    }
}
