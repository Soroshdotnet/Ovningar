using System.Collections;

namespace Övning_5_Garage_1._0
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        private T[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }


        //ToDo implamentera metoder Park och Unpark

        public bool Park(T newVehicle)
        {
            for (var i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is null)
                {
                    vehicles[i] = newVehicle;
                    return true;
                }
            }

            return false;
        }

        public bool Unpark(string regnr)
        {
            for (var i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is not null && vehicles[i].RegNr == regnr)
                {
                    vehicles[i] = null;

                    return true;
                }
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    yield return vehicle;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
