namespace Övning_5_Garage_1._0
{
    internal abstract class Vehicle
    {
        public string RegNr { get; set; }

        public Vehicle(string regnr)
        {
            RegNr = regnr;
        }

        public virtual string VehicleInfo()
        {
            return $"Type: {this.GetType().Name}, License plate: {RegNr}, ";
        }
    }
}
