using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            var masterOfPuppets = new CD();
            var titanic = new DVD();
            // TODO: Call each CD and DVD method to verify that they work as expected.

            masterOfPuppets.PlayMedia();
            titanic.PlayMedia();

            masterOfPuppets.SpinDisc();
            titanic.SpinDisc();

            titanic.WriteData("dummydata1");
            Console.WriteLine(titanic.FreeSpace);
            titanic.WriteData("dummydata2");
            Console.WriteLine(titanic.FreeSpace);
            titanic.WriteData("dummydata3");
            Console.WriteLine(titanic.FreeSpace);

            Console.WriteLine();
            titanic.ReadData();
            Console.WriteLine(titanic.FreeSpace);
        }
    }
}
