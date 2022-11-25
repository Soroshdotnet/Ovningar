namespace Övning_5_Garage_1._0
{
    internal class Garage
    {

        //ToDo: Print Array from Garage
        private string[] vehicle = new string[4];

        public string Fordon
        {
            get => vehicle[0];
            set
            {
                vehicle[0] = "A";
                vehicle[1] = "B";
                vehicle[2] = "C";
                vehicle[3] = "D";
                vehicle[4] = "E";

            }
        }


    }
}
