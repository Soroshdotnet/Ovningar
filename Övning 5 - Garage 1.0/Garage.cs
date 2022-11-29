using System.Collections;

namespace Övning_5_Garage_1._0
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        public T[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }


        //ToDo implamentera metoder Park och Unpark

        public bool Park(T newVehicle)
        {
            vehicles[0] = newVehicle;
            return false;
        }

        public bool Unpark(string regnr)
        {
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
