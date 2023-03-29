namespace cv08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArchiveOfTemperatures temp = new ArchiveOfTemperatures();
            Console.WriteLine("Read from file:");
            temp.Load("readtemps.txt");
            temp.PrintTemps();
            Console.WriteLine("");
            Console.WriteLine("Find:");
            temp.Find(2021);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Monthly average temps: ");
            temp.PrintAverageMonthlyTemps();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Year average temps: ");
            temp.PrintAverageTemps();
            Console.WriteLine("");
            Console.WriteLine("Calibrate: ");
            temp.Calibrate(-0.1);
            Console.WriteLine("");
            Console.WriteLine("Save to file:");
            temp.Save("savetemps.txt");
        }
    }
}