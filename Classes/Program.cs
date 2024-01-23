namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //dot notation
            Car Pony = new Car();
            Pony.Make = "Ford";
            Pony.Model = "Bronco";
            Pony.Year = 1966;

            //OIS
            Car car2 = new Car() {Make = "Ford", Model = "Bronco II", Year = 1983};

           

        }
    }
}
