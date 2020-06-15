using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        
        
        // TODO: Implement your custom interface.
        public CD() : base("CD", 700, 200, 800)
        {
            
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public void PlayMedia()
        {
            Console.WriteLine("Playing music from CD");
        }
    }
}
