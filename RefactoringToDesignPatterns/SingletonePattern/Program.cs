using System;

namespace SingletonePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricKettle kettle = ElectricKettle.GetInstance;

            Console.WriteLine("Kettle 1");
            Console.WriteLine(kettle.Message);

            kettle.Fill();
            Console.WriteLine(kettle.Message);

            kettle.Boil();
            Console.WriteLine(kettle.Message);

            kettle.Drain();
            Console.WriteLine(kettle.Message);

            kettle.ExecuteWhatIsNecessary();
            Console.WriteLine(kettle.Message);


            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Kettle 2");
            ElectricKettle kettle2 = ElectricKettle.GetInstance;
            Console.WriteLine(kettle2.Message);

            kettle.ExecuteWhatIsNecessary();
            Console.WriteLine(kettle2.Message);


            Console.ReadLine();
        }
    }
}
