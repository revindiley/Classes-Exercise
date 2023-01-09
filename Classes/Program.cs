namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car()
            {
                Make = "Ford",
                Model = "Edge",
                Year = 2017
                
            };
           Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");
        }
    }
}
