using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        public DVD() : base("DVD", 4700, 1000, 3000)
        {

        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        public void PlayMedia()
        {
            Console.WriteLine("Playing movie from DVD.");
        }
    }
}
