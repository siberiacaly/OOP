using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PassengerCar fabka = new PassengerCar(35, Car.TypeOfFuel.petrol, 5, 18, 7);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            PassengerCar karosa = new PassengerCar(35, Car.TypeOfFuel.petrol, 5, 18);
            Lorry nakladak = new Lorry(100, Car.TypeOfFuel.diesel, 50);

            Console.WriteLine(karosa);
            Console.WriteLine(nakladak);

            karosa.TurnRadio(true);
            nakladak.TurnRadio(true);

            Console.WriteLine(karosa);
            Console.WriteLine(nakladak);

            karosa.SetPreset(2, 88.3);
            karosa.SetPreset(1, 84.3);
            nakladak.SetPreset(2, 105.85);
            nakladak.SetPreset(1, 101.5);
            karosa.RetuneFromPreset(2);
            nakladak.RetuneFromPreset(1);

            try
            {
                nakladak.RetuneFromPreset(3);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }



            Console.WriteLine(karosa);
            Console.WriteLine(nakladak);
            karosa.TurnRadio(false);
            nakladak.TurnRadio(false);
            Console.WriteLine(karosa);
            Console.WriteLine(nakladak);



            Console.WriteLine();



            karosa.Refuel(Car.TypeOfFuel.petrol, 6.9);

            try
            {
                nakladak.Refuel(Car.TypeOfFuel.petrol, 80);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            try
            {
                karosa.Refuel(Car.TypeOfFuel.petrol, 50);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(karosa);
            Console.WriteLine(nakladak);
            Console.WriteLine();


            nakladak.Refuel(Car.TypeOfFuel.diesel, 100);

            try
            {
                karosa.TransportedPersons = 20;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                nakladak.TransportedLoad = 70;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            karosa.TransportedPersons = 2;
            nakladak.TransportedLoad = 40;
            Console.WriteLine(karosa);
            Console.WriteLine(nakladak);
            Console.WriteLine();
        }
    }
}